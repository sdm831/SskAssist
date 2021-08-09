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


namespace SskAssistWF
{
    public partial class Form1 : Form
    {
        DataObjects dataSbp = new DataObjects("Sbp");
        DataObjects dataCkps = new DataObjects("Ckps");
        DataObjects dataCos = new DataObjects("Cos");
        DataObjects dataSdm = new DataObjects("Sdm");
        DataObjects dataHdm = new DataObjects("Hdm");        
        DataObjects dataManual = new DataObjects("Manual");
        
        //List<DataObjects> subSystems = new List<DataObjects>()
        //{
        //    new DataObjects("Ckps"),
        //    new DataObjects("Cos"),
        //    new DataObjects("Sbp"),
        //    new DataObjects("Sdm"),
        //    new DataObjects("Hdm"),
        //    new DataObjects("Manual")
        //};        

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
            DataObjects.PathConfProd[0] = ofdPro.FileName;
            DataObjects.PathConfProd[1] = ofdPro.SafeFileName;
        }

        private void BtnChooseSst_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSst = new OpenFileDialog();
            ofdSst.ShowDialog();
            textBoxPathSst.Text = ofdSst.FileName;      // полный путь до файла
            textBoxPathSst.Tag = ofdSst.SafeFileName;   // имя файла
            DataObjects.PathConfStend[0] = ofdSst.FileName;
            DataObjects.PathConfStend[1] = ofdSst.SafeFileName;
        }

        private void btnChooseDest_Click(object sender, EventArgs e)
        {
            var fbdDest = new FolderBrowserDialog();
            if (fbdDest.ShowDialog() == DialogResult.OK)
            {
                textBoxPathDest.Text = fbdDest.SelectedPath;
                DataObjects.PathDestDir = fbdDest.SelectedPath;
            }            
        }

        private void btnGetDiff_Click(object sender, EventArgs e)
        {
            DateTime currrentDate = DateTime.Now;
            var pathDestDir = $@"{DataObjects.PathDestDir}\Diff";
            var pathProdObjects = $@"{pathDestDir}\Prod_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var pathStendObjects = $@"{pathDestDir}\Stend_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var pathDiffObjects   = $@"{pathDestDir}\Diff_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var pathConfigProdDel = $@"{pathDestDir}\Prod_Config_Del_{currrentDate:yyyyMMdd_HHmm}.xml";

            Print.CheckDir($@"{DataObjects.PathDestDir}\Diff\");

            // получение конфигов и списков серверов
            var ObjectProd = new MyDataObject(textBoxPathPro.Text.ToString());
            var ObjectStend = new MyDataObject(textBoxPathSst.Text.ToString());
            
            ObjectProd.Servers.PrintServers("Prod", pathProdObjects);
            ObjectStend.Servers.PrintServers("SST", pathStendObjects);
            
            // создание и получение списка объектов по серверам                                
            SortedDictionary<string, Server> proServerObjects = new SortedDictionary<string, Server>();
            foreach (var serverName in ObjectProd.Servers)
            {
                proServerObjects.Add(serverName, new Server(serverName, ObjectProd.ConfigFull));
            }
            
            SortedDictionary<string, Server> sstServerObjects = new SortedDictionary<string, Server>();
            foreach (var serverName in ObjectStend.Servers)
            {
                sstServerObjects.Add(serverName, new Server(serverName, ObjectStend.ConfigFull));
            }
            
            // вывод в файл полного списка объектов
            proServerObjects.PrintAllObj(pathProdObjects, "Prod");
            sstServerObjects.PrintAllObj(pathStendObjects, "SST");
            
            // удаление одинаковых объектов
            ComparerObjects.RemoveDublicates(proServerObjects, sstServerObjects);
            
            // вывод уникальных объектов
            sstServerObjects.PrintAllObj(pathDiffObjects, "Added");
            proServerObjects.PrintAllObj(pathDiffObjects, "Deleted");

            //Print.PrintConfigDel(ObjectProd.ConfigFullArr, destinationDir);
            ObjectProd.ConfigFullDel = Parse.GetConfigDel(ObjectProd.ConfigFull, proServerObjects);
            Print.PrintConfigDel(ObjectProd.ConfigFullDel, pathConfigProdDel);

            Process.Start("explorer.exe", $@"{DataObjects.PathDestDir}\Diff");
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

        //private void textBoxSqlStend_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
