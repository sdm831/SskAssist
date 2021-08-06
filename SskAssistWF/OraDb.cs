using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;
//using Oracle.ManagedDataAccess.Client;

namespace SskAssistWF
{
    public class OraDb
    {
        public static string credentialProd = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.173)(PORT = 1521))"
                                                        + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = orcl)));"    // SERVICE_NAME = orclcdb
                                                        + "User Id=system;Password=oracle;";
        public static string credentialStend = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.173)(PORT = 1521))"
                                                    + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = orcl)));"
                                                    + "User Id=monitor_stend;Password=monitor_stend;";
        public static string sqlStendAll = "select content from monitor_stend.ism_text_file where id = 'itecoWasConfig'";
        
        public static string sqlProdCkps = "select content from monitor_stend.ism_text_file where id = itecoWasConfig";
        public static string sqlProdCos = "select content from monitor_stend.ism_text_file where id = itecoWasConfig";
        public static string sqlProdSbp = "select content from monitor_stend.ism_text_file where id = itecoWasConfig";
        public static string sqlProdSdm = "select content from monitor_stend.ism_text_file where id = itecoWasConfig";
        public static string sqlProdHdm = "select content from monitor_stend.ism_text_file where id = itecoWasConfig";

        OracleConnection oraConnect = new OracleConnection();
        
        public void OpenConnection()
        {
            try
            {
                if (oraConnect.State == System.Data.ConnectionState.Closed)
                {
                    oraConnect.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (oraConnect.State == System.Data.ConnectionState.Open)
                {
                    oraConnect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public OracleConnection GetConnection()
        {
            return oraConnect;
        }

        //public static string[] GetConfigFromDb(OracleConnection oraConnect, string sql)
        public static string GetConfigFromDb(OracleConnection oraConnect, string sql)
        {
            //string[] responce = new string[] { };
            string responce = "";

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = oraConnect;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {

                if (reader.HasRows)
                {
                    string[] separator = new string[] { "\n\t" };
                    while (reader.Read())
                    {                        
                        //responce = reader.GetTextReader(0).ReadToEnd().Split(separator, StringSplitOptions.None);
                        responce = reader.GetTextReader(0).ReadToEnd();                        
                    }
                }
            }            
            return responce;
        }




        //public static List<string> GetConfigFromDb(OracleConnection oraConnect, string sql)
        //{
        //    List<string> responce = new List<string>();

        //    OracleCommand cmd = new OracleCommand();

        //    cmd.Connection = oraConnect;
        //    cmd.CommandText = sql;

        //    using (DbDataReader reader = cmd.ExecuteReader())
        //    {

        //        if (reader.HasRows)
        //        {

        //            while (reader.Read())
        //            {
        //                responce.Add($"{reader.GetString(0)} {reader.GetString(1)}");
        //            }
        //        }
        //    }
        //    if (responce != null)
        //    {
        //        var str = "";
        //        foreach(var item in responce)
        //        {
        //            str += $"{item}\n";
        //        }
        //        MessageBox.Show($"Row counts: {responce.Count().ToString()}\n{str}");
        //        //MessageBox.Show(responce[0]);
        //    }
        //    return responce;
        //}
    }
}