using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SskAssistWF
{
    public class DataObjects
    {
        public static string[] PathConfProd { get; set; } = new string[2];
        public static string[] PathConfStend { get; set; } = new string[2];
        //

        // -------------------------------------------------

        public string[] ConfigProdFull { get; set; }
        public string[] ConfigProdDel { get; set; }
        public string[] ConfigProdDelAdd { get; set; }

        public string[] ConfigStendFull { get; set; }
        public string[] ConfigStendDel { get; set; }
        public string[] ConfigStendDelAdd { get; set; }


        public SortedSet<string> ServersProd = new SortedSet<string>();
        public SortedSet<string> ServersStend = new SortedSet<string>();

        

        //this.ConfigProdFull = File.ReadAllLines(strPath);
        //Servers = Parse.GetListObjects(ConfigFullArr, " serverName=", "status");

        

    }
}
