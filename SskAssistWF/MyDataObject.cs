using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SskAssistWF
{
    public class MyDataObject
    {        
        public string[] ConfigFull { get; set; }
        public string[] ConfigFullDel { get; set; }
        public string[] ConfigFullDelAdd { get; set; }

        public SortedSet<string> Servers = new SortedSet<string>();        

        public MyDataObject(string strPath) 
        {
            try
            {
                ConfigFull = File.ReadAllLines(strPath, Print.ISO88595);                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Servers = Parse.GetListObjects(ConfigFull, " serverName=", "status");            
        }
    }
}
