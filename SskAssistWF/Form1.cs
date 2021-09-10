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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
                
        private void btnChooseOld_Click(object sender, EventArgs e)
        {
            // choose OLD file for compare
            OpenFileDialog ofdOld = new OpenFileDialog();
            ofdOld.ShowDialog();
                        
            textBoxPathOld.Text = ofdOld.FileName;
            textBoxPathOld.Tag = ofdOld.SafeFileName;
            Data.PathToConfigFileOld[0] = ofdOld.FileName;
            Data.PathToConfigFileOld[1] = ofdOld.SafeFileName;
        }

        private void BtnChooseNew_Click(object sender, EventArgs e)
        {
            // choose NEW file for compare
            OpenFileDialog ofdNew = new OpenFileDialog();
            ofdNew.ShowDialog();

            textBoxPathNew.Text = ofdNew.FileName;      // полный путь до файла
            textBoxPathNew.Tag = ofdNew.SafeFileName;   // имя файла
            Data.PathToConfigFileStend[0] = ofdNew.FileName;
            Data.PathToConfigFileStend[1] = ofdNew.SafeFileName;
        }

        private void btnChooseDest_Click(object sender, EventArgs e)
        {
            // choose destination directory
            var fbdDest = new FolderBrowserDialog();
            if (fbdDest.ShowDialog() == DialogResult.OK)
            {
                textBoxPathDest.Text = fbdDest.SelectedPath;
                Data.PathToDestDir = fbdDest.SelectedPath;
            }
        }

        private void btnChooseDiff_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdDiff = new OpenFileDialog();
            ofdDiff.ShowDialog();

            textBoxPathDiff.Text = ofdDiff.FileName;      // полный путь до файла
            textBoxPathDiff.Tag = ofdDiff.SafeFileName;   // имя файла
            Data.PathToExpDiffObjsJson = ofdDiff.FileName;            
        }
                
        private void btnCompare_Click(object sender, EventArgs e)
        {
            // set time
            Data.UpdateFileNames(DateTime.Now);

            // get configs from files
            Data.ConfigOldFull = Data.GetConfigFromFile(Data.PathToConfigFileOld[0]);
            Data.ConfigNewFull = Data.GetConfigFromFile(Data.PathToConfigFileStend[0]);

            // get servers and objects from array configs
            Data.serversOldAll = Parse.GetListServers(Data.ConfigOldFull);
            Data.serversNewAll = Parse.GetListServers(Data.ConfigNewFull);
            
            // check dir
            Print.CheckDir(Data.PathToDestDir);
                        
            // export all objects to json files
            File.AppendAllText(Data.PathToExpOldAllObjsJson, JsonConvert.SerializeObject(Data.serversOldAll, Formatting.Indented));
            File.AppendAllText(Data.PathToExpNewAllObjsJson, JsonConvert.SerializeObject(Data.serversNewAll, Formatting.Indented));

            // get unic objects
            Data.serversOldUnic = Parse.GetServersUnicObjs(Data.serversOldAll, Data.serversNewAll);
            Data.serversNewUnic = Parse.GetServersUnicObjs(Data.serversNewAll, Data.serversOldAll);

            // add to dictionary for export to json
            Data.dictDiffObjs.Clear();
            Data.dictDiffObjs.Add("Added to New",     Data.serversNewUnic);
            Data.dictDiffObjs.Add("Deleted from Old", Data.serversOldUnic);
                                    
            File.AppendAllText(Data.PathToExpDiffObjsJson, JsonConvert.SerializeObject(Data.dictDiffObjs, Formatting.Indented));

            textBoxPathDiff.Text = Data.PathToExpDiffObjsJson;

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
                  
            Data.serversNewUnic = Data.dictDiffObjs["Added to New"];
            Data.serversOldUnic = Data.dictDiffObjs["Deleted from Old"];

            // get config "Del"
            Data.ConfigOldDel = Parse.GetConfigDel(Data.ConfigOldFull, Data.serversOldUnic);

            // export config *_Del_* to file
            Print.PrintConfig(Data.ConfigOldDel, Data.PathToExpConfigProdDel);

            // get config "Add" 
            Data.ConfigOldAdd = Parse.GetConfigAdd(Data.ConfigOldDel, Data.serversNewUnic);

            // export config *_Add_* to file
            Print.PrintConfig(Data.ConfigOldAdd, Data.PathToExpConfigOldDelAdd);

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
