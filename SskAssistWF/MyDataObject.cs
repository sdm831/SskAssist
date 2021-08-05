using System.Collections.Generic;
using System.IO;

namespace SskAssistWF
{
    public class MyDataObject
    {        
        public string[] ConfigFullArr { get; set; }
        public SortedSet<string> Servers = new SortedSet<string>();        

        public MyDataObject(string strPath) 
        {
            ConfigFullArr = File.ReadAllLines(strPath);
            Servers = Parse.GetListObjects(ConfigFullArr, " serverName=", "status");            
        }
    }
}
