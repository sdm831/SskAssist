using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SskAssistWF
{
    public class Data
    {
        public static DateTime CurrrentDate { get; set; }

        public static string[] PathToConfigFileProd { get; set; } = new string[2];
        public static string[] PathToConfigFileStend { get; set; } = new string[2];
        public static string   PathToDestDir { get; set; } = @"c:\tmp";
        

        public static string PathToExpProdAllObjs       { get; set; }
        public static string PathToExpProdAllObjsJson   { get; set; }
        public static string PathToExpProdUnicObjsJson  { get; set; }
        public static string PathToExpStendAllObjs         { get; set; }
        public static string PathToExpDiffObjs          { get; set; }
        public static string PathToExpDiffObjsJson      { get; set; }
        
        public static string PathToExpConfigProdDel     { get; set; }
        public static string PathToExpConfigProdDelAdd  { get; set; }
        
        public static string PathToExpStendAllObjsJson  { get; set; }
        public static string PathToExpStendUnicObjsJson { get; set; }


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

        public static Dictionary<string, SortedSet<Server>> dictDiffObjs = new Dictionary<string, SortedSet<Server>>();

        internal static void UpdateFileNames(DateTime now)
        {
            CurrrentDate = now;

            PathToExpProdAllObjs          = $@"{PathToDestDir}\Prod_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpStendAllObjs         = $@"{PathToDestDir}\Stend_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";

            PathToExpProdAllObjsJson      = $@"{PathToDestDir}\Prod_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";
            PathToExpStendAllObjsJson     = $@"{PathToDestDir}\Stend_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";

            PathToExpProdUnicObjsJson     = $@"{PathToDestDir}\Prod_Unic_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";
            PathToExpStendUnicObjsJson    = $@"{PathToDestDir}\Stend_Unic_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";
                        
            PathToExpDiffObjs             = $@"{PathToDestDir}\Diff_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpDiffObjsJson         = $@"{PathToDestDir}\Diff_Objects_{CurrrentDate:yyyyMMdd_HHmm}.json";
            
            PathToExpConfigProdDel        = $@"{PathToDestDir}\Prod_New_Config_Del_{CurrrentDate:yyyyMMdd_HHmm}.xml";
            PathToExpConfigProdDelAdd     = $@"{PathToDestDir}\Prod_New_Config_Del_Add_{CurrrentDate:yyyyMMdd_HHmm}.xml";
            
            
        }

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
    }
}
