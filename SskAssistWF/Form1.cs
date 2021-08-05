using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //MyDataObject myDataObject = new MyDataObject("");

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
        }

        private void BtnChooseSst_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSst = new OpenFileDialog();
            ofdSst.ShowDialog();
            textBoxPathSst.Text = ofdSst.FileName;      // полный путь до файла
            textBoxPathSst.Tag = ofdSst.SafeFileName;   // имя файла
        }

        private void btnChooseDest_Click(object sender, EventArgs e)
        {
            var fbdDest = new FolderBrowserDialog();
            if (fbdDest.ShowDialog() == DialogResult.OK)
            {
                textBoxPathDest.Text = fbdDest.SelectedPath;
            }            
        }

        private void btnGetDiff_Click(object sender, EventArgs e)
        {
            DateTime currrentDate = DateTime.Now;

            var listObjProPath = $@"{textBoxPathDest.Text}\{textBoxPathPro.Tag}_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var listObjSstPath = $@"{textBoxPathDest.Text}\{textBoxPathSst.Tag}_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            var listDiffPath = $@"{textBoxPathDest.Text}\Diff_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            
            // получение конфигов и списков серверов
            var proConfig = new MyDataObject(textBoxPathPro.Text.ToString());
            var sstConfig = new MyDataObject(textBoxPathSst.Text.ToString());
            
            proConfig.Servers.PrintServers("Prod", listObjProPath);
            sstConfig.Servers.PrintServers("SST", listObjSstPath);
            
            // создание и получение списка объектов по серверам                                
            SortedDictionary<string, Server> proServerObjects = new SortedDictionary<string, Server>();
            foreach (var serverName in proConfig.Servers)
            {
                proServerObjects.Add(serverName, new Server(serverName, proConfig.ConfigFullArr));
            }
            
            SortedDictionary<string, Server> sstServerObjects = new SortedDictionary<string, Server>();
            foreach (var serverName in sstConfig.Servers)
            {
                sstServerObjects.Add(serverName, new Server(serverName, sstConfig.ConfigFullArr));
            }
            
            // вывод в файл полного списка объектов
            proServerObjects.PrintAllObj(listObjProPath, "Prod");
            sstServerObjects.PrintAllObj(listObjSstPath, "SST");
            
            // удаление одинаковых объектов
            ComparerObjects.RemoveDublicates(proServerObjects, sstServerObjects);
            
            // вывод уникальных объектов
            sstServerObjects.PrintAllObj(listDiffPath, "Added");
            proServerObjects.PrintAllObj(listDiffPath, "Deleted");
        }

                        

        private void btnRunSqlStend_Click(object sender, EventArgs e)
        {
            //string sql = "Select product_id, ad_sourcetext from pm.print_media where id > 3000;";
            string sql = textBoxSqlStend.Text;
            var responce = new List<string>();

            OraDb db = new OraDb();
            db.GetConnection().ConnectionString = OraDb.credentialStend;
            db.OpenConnection();
            try
            {
                responce = OraDb.GetDataFromDb(db.GetConnection(), sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.CloseConnection();            
        }                

        private void btnRunSqlProd_Click(object sender, EventArgs e)
        {
            string sql = textBoxSqlProd.Text;
            var responce = new List<string>();

            OraDb db = new OraDb();
            db.GetConnection().ConnectionString = OraDb.credentialStend;
            db.OpenConnection();
            try
            {
                responce = OraDb.GetDataFromDb(db.GetConnection(), sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.CloseConnection();
        }

        //private void textBoxSqlStend_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
