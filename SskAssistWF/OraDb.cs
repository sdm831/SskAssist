using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
//using Oracle.ManagedDataAccess.Client;

namespace SskAssistWF
{
    public class OraDb
    {
        public static string credentialProd = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.173)(PORT = 1521))"
                                                        + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = orclcdb)));"
                                                        + "User Id= system;Password=oracle;";
        public static string credentialStend = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.173)(PORT = 1521))"
                                                    + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = orclcdb)));"
                                                    + "User Id= monitor_stend;Password=monitor_stend;";
        //protected string Credential { get; }

        //public OraDb(string cred)
        //{
        //    Credential = cred;
        //}

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
            if (oraConnect.State == System.Data.ConnectionState.Open)
            {
                oraConnect.Close();
            }
        }

        public OracleConnection GetConnection()
        {
            return oraConnect;
        }

        //OracleConnection oraConnect = new OracleConnection(credentials);
        //oraConnect.Open();
        //try
        //{
        //    GetDataFromDb(oraConnect, "");
        //}
        //catch (Exception e)
        //{                
        //    Console.WriteLine(e.StackTrace);
        //}
        //finally
        //{
        //    oraConnect.Close();
        //    oraConnect.Dispose();
        //}            


        public static List<string> GetDataFromDb(OracleConnection oraConnect, string sql)
        {
            List<string> responce = new List<string>();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = oraConnect;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {               

                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        // Индекс (index) столбца Emp_ID в команде SQL.
                        responce.Add($"{reader.GetString(0)} {reader.GetString(1)}");
                    }
                }
            }
            return responce;
        }
    }
}