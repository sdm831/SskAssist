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

        public static string[] PathToConfigFileOld { get; set; } = new string[2];
        public static string[] PathToConfigFileStend { get; set; } = new string[2];
        public static string   PathToDestDir { get; set; } = @"c:\tmp";
        

        public static string PathToExpOldAllObjs       { get; set; }
        public static string PathToExpOldAllObjsJson   { get; set; }
        public static string PathToExpOldUnicObjsJson  { get; set; }
        public static string PathToExpNewAllObjs         { get; set; }
        public static string PathToExpDiffObjs          { get; set; }
        public static string PathToExpDiffObjsJson      { get; set; }
        
        public static string PathToExpConfigProdDel     { get; set; }
        public static string PathToExpConfigOldDelAdd  { get; set; }
        
        public static string PathToExpNewAllObjsJson  { get; set; }
        public static string PathToExpStendUnicObjsJson { get; set; }


        public static string[] ConfigOldFull { get; set; }
        public static string[] ConfigOldDel { get; set; }
        public static string[] ConfigOldAdd { get; set; }

        public static string[] ConfigNewFull { get; set; }
        public static string[] ConfigNewDel { get; set; }
        public static string[] ConfigNewAdd { get; set; }


        public static SortedSet<Server> serversOldAll { get; set; } = new SortedSet<Server>();
        public static SortedSet<Server> serversOldUnic { get; set; } = new SortedSet<Server>();
        public static SortedSet<Server> serversNewAll { get; set; } = new SortedSet<Server>();
        public static SortedSet<Server> serversNewUnic { get; set; } = new SortedSet<Server>();

        public static Dictionary<string, SortedSet<Server>> dictDiffObjs = new Dictionary<string, SortedSet<Server>>();

        internal static void UpdateFileNames(DateTime now)
        {
            CurrrentDate = now;

            PathToExpOldAllObjs         = $@"{PathToDestDir}\Old_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpNewAllObjs         = $@"{PathToDestDir}\New_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";

            PathToExpOldAllObjsJson     = $@"{PathToDestDir}\Old_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";
            PathToExpNewAllObjsJson     = $@"{PathToDestDir}\New_All_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";

            PathToExpOldUnicObjsJson    = $@"{PathToDestDir}\Old_Unic_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";
            PathToExpStendUnicObjsJson  = $@"{PathToDestDir}\New_Unic_Objects_{CurrrentDate:yyyyMMdd_HHmm}.Json";
                        
            PathToExpDiffObjs           = $@"{PathToDestDir}\Diff_Objects_{CurrrentDate:yyyyMMdd_HHmm}.txt";
            PathToExpDiffObjsJson       = $@"{PathToDestDir}\Diff_Objects_{CurrrentDate:yyyyMMdd_HHmm}.json";
            
            PathToExpConfigProdDel      = $@"{PathToDestDir}\Old_New_Config_Del_{CurrrentDate:yyyyMMdd_HHmm}.xml";
            PathToExpConfigOldDelAdd    = $@"{PathToDestDir}\New_New_Config_Add_{CurrrentDate:yyyyMMdd_HHmm}.xml";            
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
