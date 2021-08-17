using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Newtonsoft.Json;


namespace SskAssistWF
{
    public partial class Form1 : Form
    {
        //DataObjects dataSbp = new DataObjects("Sbp");
        //DataObjects dataCkps = new DataObjects("Ckps");
        //DataObjects dataCos = new DataObjects("Cos");
        //DataObjects dataSdm = new DataObjects("Sdm");
        //DataObjects dataHdm = new DataObjects("Hdm");        
        //DataObjects dataManual = new DataObjects("Manual");
                       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
                
        private void btnChoosePro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPro = new OpenFileDialog();
            ofdPro.ShowDialog();
                        
            textBoxPathPro.Text = ofdPro.FileName;
            textBoxPathPro.Tag = ofdPro.SafeFileName;
            Data.PathToConfigFileProd[0] = ofdPro.FileName;
            Data.PathToConfigFileProd[1] = ofdPro.SafeFileName;
        }

        private void BtnChooseSst_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSst = new OpenFileDialog();
            ofdSst.ShowDialog();

            textBoxPathStend.Text = ofdSst.FileName;      // полный путь до файла
            textBoxPathStend.Tag = ofdSst.SafeFileName;   // имя файла
            Data.PathToConfigFileStend[0] = ofdSst.FileName;
            Data.PathToConfigFileStend[1] = ofdSst.SafeFileName;
        }

        private void btnChooseDest_Click(object sender, EventArgs e)
        {
            var fbdDest = new FolderBrowserDialog();
            if (fbdDest.ShowDialog() == DialogResult.OK)
            {
                textBoxPathDest.Text = fbdDest.SelectedPath;
                Data.PathToDestDir = fbdDest.SelectedPath;
            }
        }                

        //private void btnGetDiff_Click(object sender, EventArgs e)
        //{
        //    DateTime currrentDate = DateTime.Now;
        //    Data.CurrrentDate = currrentDate;
        //    //var pathDestDir       = $@"{DataObjects.PathDestDir}\Diff";
        //    var pathProdObjects   = $@"{DataObjects.PathDestDir}\Prod_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
        //    var pathStendObjects  = $@"{DataObjects.PathDestDir}\Stend_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
        //    var pathDiffObjects   = $@"{DataObjects.PathDestDir}\Diff_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
        //    var pathConfigProdDel = $@"{DataObjects.PathDestDir}\Prod_Config_Del_{currrentDate:yyyyMMdd_HHmm}.xml";
        //
        //    Print.CheckDir($@"{DataObjects.PathDestDir}\Diff\");
        //
        //    // получение конфигов и списков серверов
        //    var ServersProd = new MyDataObject(textBoxPathPro.Text.ToString());
        //    var ServersStend = new MyDataObject(textBoxPathSst.Text.ToString());
        //    
        //    ServersProd.Servers.PrintServers("Prod", pathProdObjects);
        //    ServersStend.Servers.PrintServers("SST", pathStendObjects);
        //    
        //    // создание и получение списка объектов по серверам                                
        //    SortedDictionary<string, Server> proServerObjects = new SortedDictionary<string, Server>();
        //    foreach (var serverName in ServersProd.Servers)
        //    {
        //        //proServerObjects.Add(serverName, new Server(serverName, ServersProd.ConfigFull));
        //    }
        //    
        //    SortedDictionary<string, Server> sstServerObjects = new SortedDictionary<string, Server>();
        //    foreach (var serverName in ServersStend.Servers)
        //    {
        //        //sstServerObjects.Add(serverName, new Server(serverName, ServersStend.ConfigFull));
        //    }
        //                
        //    // удаление одинаковых объектов
        //    ComparerObjects.RemoveDublicates(proServerObjects, sstServerObjects);
        //                
        //    Print.PrintConfigDel(ServersProd.ConfigFullDel, pathConfigProdDel);
        //
        //    Process.Start("explorer.exe", $@"{DataObjects.PathDestDir}\Diff");
        //}
        
        private void btnCompare_Click(object sender, EventArgs e)
        {
            // set time
            Data.UpdateFileNames(DateTime.Now);

            // get configs from files
            Data.ConfigProdFull =  Data.GetConfigFromFile(Data.PathToConfigFileProd[0]);
            Data.ConfigStendFull = Data.GetConfigFromFile(Data.PathToConfigFileStend[0]);

            // get servers and objects from array configs
            Data.serversProdAll =  Parse.GetListServers(Data.ConfigProdFull);
            Data.serversStendAll = Parse.GetListServers(Data.ConfigStendFull);
            
            // check dir
            Print.CheckDir(Data.PathToDestDir);
                        
            // export all objects to json files
            File.AppendAllText(Data.PathToExpProdAllObjsJson,  JsonConvert.SerializeObject(Data.serversProdAll, Formatting.Indented));
            File.AppendAllText(Data.PathToExpStendAllObjsJson, JsonConvert.SerializeObject(Data.serversStendAll, Formatting.Indented));

            // get unic objects
            Data.serversProdUnic  = Parse.GetServersUnicObjs(Data.serversProdAll,  Data.serversStendAll);
            Data.serversStendUnic = Parse.GetServersUnicObjs(Data.serversStendAll, Data.serversProdAll);

            // add to dictionary for export to json
            Data.dictDiffObjs.Clear();
            Data.dictDiffObjs.Add("Added to Stend", Data.serversStendUnic);
            Data.dictDiffObjs.Add("Deleted from Prod", Data.serversStendUnic);
                                    
            File.AppendAllText(Data.PathToExpDiffObjsJson, JsonConvert.SerializeObject(Data.dictDiffObjs, Formatting.Indented));

            Process.Start("explorer.exe", Data.PathToDestDir);
        }
        
        private void btnGenNewConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Data.dictDiffObjs = JsonConvert.DeserializeObject<Dictionary<string, SortedSet<Server>>>(File.ReadAllText(Data.PathToExpDiffObjsJson));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                  
            Data.serversProdUnic  = Data.dictDiffObjs["Added to Stend"];
            Data.serversStendUnic = Data.dictDiffObjs["Deleted from Prod"];

            // get config "Del"
            Data.ConfigProdDel = Parse.GetConfigDel(Data.ConfigProdFull, Data.serversProdUnic);

            // export config *_Del_* to file
            Print.PrintConfigDel(Data.ConfigProdDel, Data.PathToExpConfigProdDel);

            // get config "Add" 
            Data.ConfigProdAdd = Parse.GetConfigAdd(Data.ConfigProdDel, Data.serversStendUnic);

            Process.Start("explorer.exe", Data.PathToDestDir);
        }

        private void btnRunSqlStend_Click(object sender, EventArgs e)
        {
            //string sql = "Select product_id, ad_sourcetext from pm.print_media where id > 3000;";
            //string sql = textBoxSqlStend.Text;
            //var responce = new List<string>();
            //
            //OraDb db = new OraDb();
            //db.GetConnection().ConnectionString = OraDb.credentialStend;
            //db.OpenConnection();
            //try
            //{
            //    responce = OraDb.GetDataFromDb(db.GetConnection(), sql);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //db.CloseConnection();
            //
            //Print.PrintList(responce);
        }                

        private void btnRunSqlProd_Click(object sender, EventArgs e)
        {
            //string sql = textBoxSqlProd.Text;
            //var responce = new List<string>();
            //
            //OraDb db = new OraDb();
            //db.GetConnection().ConnectionString = OraDb.credentialStend;
            //db.OpenConnection();
            //try
            //{
            //    //responce = OraDb.GetDataFromDb(db.GetConnection(), sql);
            //    OraDb.GetDataFromDb(db.GetConnection(), sql);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //db.CloseConnection();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnFromDb.Checked == true)
            {
                radioBtnFromFiles.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnFromFiles.Checked == true)
            {
                radioBtnFromDb.Checked = false;
            }
        }

        //private void btnGetData_Click(object sender, EventArgs e)
        //{
            //if(radioBtnFromDb.Checked == false && radioBtnFromFiles.Checked == false)
            //{
            //    MessageBox.Show("subSystem is not checked");
            //}
            //
            //if (radioBtnFromDb.Checked == true)
            //{
            //    if (comboBoxChooseSystem.Text == "Sbp") { DataImport.GetDataFromDb(dataSbp); }
            //    if (comboBoxChooseSystem.Text == "Ckps") { DataImport.GetDataFromDb(dataCkps); }
            //    if (comboBoxChooseSystem.Text == "Cos") { DataImport.GetDataFromDb(dataCos); }
            //    if (comboBoxChooseSystem.Text == "Sdm") { DataImport.GetDataFromDb(dataSdm); }
            //    if (comboBoxChooseSystem.Text == "Hdm") { DataImport.GetDataFromDb(dataHdm); }
            //}
            //
            //if(radioBtnFromFiles.Checked == true)
            //{
            //    DataImport.GetDataFromDb(dataManual);
            //}
        //}        
    }
}
