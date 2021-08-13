using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SskAssistWF
{
    public class Data
    {
        public static DateTime CurrrentDate { get; set; }

        public static string[] PathToConfigFileProd { get; set; } = new string[2];
        public static string[] PathToConfigFileStend { get; set; } = new string[2];
        public static string   PathToDestDir { get; set; } = @"c:\tmp";
        

        public static string PathToExpProdObjs         { get; set; }
        public static string PathToExpStendObjs        { get; set; }
        public static string PathToExpDiffObjs         { get; set; }
        public static string PathToExpConfigProdDel    { get; set; }
        public static string PathToExpConfigProdDelAdd { get; set; }


        public static string[] ConfigProdFull { get; set; }
        public static string[] ConfigProdDel { get; set; }
        public static string[] ConfigProdAdd { get; set; }

        public static string[] ConfigStendFull { get; set; }
        public static string[] ConfigStendDel { get; set; }
        public static string[] ConfigStendAdd { get; set; }


        public static SortedSet<Server> serversProdAll { get; set; } = new SortedSet<Server>();
        public static SortedSet<Server> serversProdUnic { get; set; } = new SortedSet<Server>();
        public static SortedSet<Server> serversStendAll { get; set; } = new SortedSet<Server>();
        public static SortedSet<Server> serversStendUnic { get; set; } = new SortedSet<Server>();

        internal static void UpdateFileNames(DateTime now)
        {
            CurrrentDate = now;

            PathToExpProdObjs          = $@"{PathToDestDir}\Prod_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpStendObjs         = $@"{PathToDestDir}\Stend_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpDiffObjs          = $@"{PathToDestDir}\Diff_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpConfigProdDel     = $@"{PathToDestDir}\Prod_New_Config_Del_{CurrrentDate:yyyyMMdd_HHmm}.xml";
            PathToExpConfigProdDelAdd  = $@"{PathToDestDir}\Prod_New_Config_Del_Add_{CurrrentDate:yyyyMMdd_HHmm}.xml";
        }
    }
}
