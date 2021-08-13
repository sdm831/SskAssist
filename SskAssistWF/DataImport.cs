using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SskAssistWF
{
    public static class DataImport
    {
        public static string[] GetConfigFromFile(string strPath)
        {
            try
            {
                return File.ReadAllLines(strPath, Print.ISO88595);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static void GetObjFromConfigFile(string path)
        {

        }
        
        
        public static void GetDataFromDb(DataObjects subSystemObj)
        {
            DateTime currrentDate = DateTime.Now;

            //subSystemObj.PathProdlistAllObj  = $@"{DataObjects.PathDestDir}\{subSystemObj.Name}\{subSystemObj.Name}_Prod_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            //subSystemObj.PathStendlistAllObj = $@"{DataObjects.PathDestDir}\{subSystemObj.Name}\{subSystemObj.Name}_Stend_All_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";
            //subSystemObj.PathlistDiff = $@"{DataObjects.PathDestDir}\{subSystemObj.Name}\{subSystemObj.Name}_Diff_Objects_{currrentDate:yyyyMMdd_HHmm}.txt";

            string confFull = "";
            OraDb db = new OraDb();
            db.GetConnection().ConnectionString = OraDb.credentialStend;
            db.OpenConnection();
            try
            {
                //subSystemObj.ConfigStendFull = OraDb.GetConfigFromDb(db.GetConnection(), OraDb.sqlStendAll);
                confFull = OraDb.GetConfigFromDb(db.GetConnection(), OraDb.sqlStendAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.CloseConnection();

            //File.AppendAllText(subSystemObj.PathProdlistAllObj, confFull);
            //var ConfigFullArr = File.ReadAllLines(subSystemObj.PathProdlistAllObj);
            //Parse.SetConfigStend(confFull, subSystemObj.Name);
        }        
    }
}
