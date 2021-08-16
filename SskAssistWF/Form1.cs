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

            textBoxPathSst.Text = ofdSst.FileName;      // полный путь до файла
            textBoxPathSst.Tag = ofdSst.SafeFileName;   // имя файла
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
                

        private void btnGetDiff_Click(object sender, EventArgs e)
        {
            DateTime currrentDate = DateTime.Now;
            Data.CurrrentDate = currrentDate;
            //var pathDestDir       = $@"{DataObjects.PathDestDir}\Diff";
            var pathProdObjects   = $@"{DataObjects.PathDestDir}\Prod_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var pathStendObjects  = $@"{DataObjects.PathDestDir}\Stend_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var pathDiffObjects   = $@"{DataObjects.PathDestDir}\Diff_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var pathConfigProdDel = $@"{DataObjects.PathDestDir}\Prod_Config_Del_{currrentDate:yyyyMMdd_HHmm}.xml";

            Print.CheckDir($@"{DataObjects.PathDestDir}\Diff\");

            // получение конфигов и списков серверов
            var ServersProd = new MyDataObject(textBoxPathPro.Text.ToString());
            var ServersStend = new MyDataObject(textBoxPathSst.Text.ToString());
            
            ServersProd.Servers.PrintServers("Prod", pathProdObjects);
            ServersStend.Servers.PrintServers("SST", pathStendObjects);
            
            // создание и получение списка объектов по серверам                                
            SortedDictionary<string, Server> proServerObjects = new SortedDictionary<string, Server>();
            foreach (var serverName in ServersProd.Servers)
            {
                //proServerObjects.Add(serverName, new Server(serverName, ServersProd.ConfigFull));
            }
            
            SortedDictionary<string, Server> sstServerObjects = new SortedDictionary<string, Server>();
            foreach (var serverName in ServersStend.Servers)
            {
                //sstServerObjects.Add(serverName, new Server(serverName, ServersStend.ConfigFull));
            }
            
            // вывод в файл полного списка объектов
            //proServerObjects.PrintAllObj(pathProdObjects, "Prod");
            //sstServerObjects.PrintAllObj(pathStendObjects, "SST");
            
            // удаление одинаковых объектов
            ComparerObjects.RemoveDublicates(proServerObjects, sstServerObjects);
            
            // вывод уникальных объектов
            //sstServerObjects.PrintAllObj(pathDiffObjects, "Added");
            //proServerObjects.PrintAllObj(pathDiffObjects, "Deleted");

            //Print.PrintConfigDel(ServersProd.ConfigFullArr, destinationDir);
            //ServersProd.ConfigFullDel = Parse.GetConfigDel(ServersProd.ConfigProdFull, proServerObjects);
            Print.PrintConfigDel(ServersProd.ConfigFullDel, pathConfigProdDel);

            Process.Start("explorer.exe", $@"{DataObjects.PathDestDir}\Diff");
        }
        
        private void btnGetDiff_Click_1(object sender, EventArgs e)
        {
            // set time
            Data.UpdateFileNames(DateTime.Now);

            // get configs from files
            Data.ConfigProdFull =  DataImport.GetConfigFromFile(Data.PathToConfigFileProd[0]);
            Data.ConfigStendFull = DataImport.GetConfigFromFile(Data.PathToConfigFileStend[0]);

            // get servers and objects from array configs
            Data.serversProdAll =  Parse.GetListServers(Data.ConfigProdFull);
            Data.serversStendAll = Parse.GetListServers(Data.ConfigStendFull);
            
            // check dir
            Print.CheckDir(Data.PathToDestDir);

            // export All objects to files
            //Print.PrintAllObj(Data.serversProdAll, Data.PathToExpProdAllObjs, "Prod");
            //Print.PrintAllObj(Data.serversStendAll, Data.PathToExpStendObjs, "Stend");
            
            // export all objects to json files
            File.AppendAllText(Data.PathToExpProdUnicObjsJson, JsonConvert.SerializeObject(Data.serversProdUnic, Formatting.Indented));
            File.AppendAllText(Data.PathToExpStendUnicObjsJson, JsonConvert.SerializeObject(Data.serversStendUnic, Formatting.Indented));

            // get unic objects
            Data.serversProdUnic  = Parse.GetServersUnicObjs(Data.serversProdAll,  Data.serversStendAll);
            Data.serversStendUnic = Parse.GetServersUnicObjs(Data.serversStendAll, Data.serversProdAll);

            // export unic objects
            Print.PrintAllObj(Data.serversStendUnic, Data.PathToExpDiffObjs, "Added to Stend");
            Print.PrintAllObj(Data.serversProdUnic, Data.PathToExpDiffObjs, "Deleted from Prod");
                                                
            // export unic objects to file.json            
            File.AppendAllText(Data.PathToExpProdUnicObjsJson, JsonConvert.SerializeObject(Data.serversProdUnic, Formatting.Indented));
            File.AppendAllText(Data.PathToExpStendUnicObjsJson, JsonConvert.SerializeObject(Data.serversStendUnic, Formatting.Indented));

            Process.Start("explorer.exe", Data.PathToDestDir);
        }
        
        private void btnGenNewConfig_Click(object sender, EventArgs e)
        {
            try
            {                
                Data.serversProdUnic = JsonConvert.DeserializeObject<SortedSet<Server>>(File.ReadAllText(Data.PathToExpProdUnicObjsJson));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Data.ConfigProdDel = Parse.GetConfigDel(Data.ConfigProdFull, Data.serversProdUnic);
            Print.PrintConfigDel(Data.ConfigProdDel, Data.PathToExpConfigProdDel);

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

        private void btnGetData_Click(object sender, EventArgs e)
        {
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
        }



        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    radioButton1.Checked
        //}

        
    }
}
