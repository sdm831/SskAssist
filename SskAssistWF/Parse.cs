using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SskAssistWF
{
    public static class Parse
    {
        public static SortedSet<string> GetListObjects(string[] configFull, string typeObj, string keyWord)
        {
            SortedSet<string> listObjects = new SortedSet<string>();

            if (typeObj.Contains("queue"))
            {
                keyWord = keyWord.ToLower().TrimPrefixAndDigits().Replace("server", "cluster");
            }            

            string objName;

            foreach (var line in configFull) {

                if (line.ToLower().Contains(keyWord.ToLower()) && !line.ToLower().Contains("exception".ToLower()))     // may add second conditions
                {
                    int resultFindStart = line.IndexOf(typeObj);
                    if (resultFindStart != -1)
                    {
                        int indexOfSubstringStart = line.IndexOf('"', resultFindStart) + 1;
                        int indexOfSubstringEnd = line.IndexOf('"', indexOfSubstringStart + 1);

                        objName = line.Substring(indexOfSubstringStart, indexOfSubstringEnd - indexOfSubstringStart);


                                // исключение дублированных систем (12,21,22) и ODR серверов
                        if (!listObjects.Any(s => s.Contains(objName.TrimPrefixAndDigits())) && !objName.TrimPrefixAndDigits().ToLower().Contains("odr"))
                        {
                            listObjects.Add(objName);
                        }
                    }
                }
            }
            return listObjects;
        }

        public static void SetConfigStend(string confFull, string name)
        {
            
        }

        public static SortedSet<string> GetListObjects(string[] configFull, string typeObj, string keyWord, bool enpoint)
        {
            SortedSet<string> listObjects = new SortedSet<string>();

            foreach (var line in configFull)
            {
                if (line.ToLower().Contains(keyWord.ToLower()))
                {
                    int resultFindStart = line.IndexOf(typeObj);
                    if (resultFindStart != -1)
                    {                        
                        listObjects.Add($"endpoint");     // потому что у сервера не больше 1 ендпоинта
                    }
                }
            }
            return listObjects;
        }

        public static string TrimPrefixAndDigits(this string str)
        {
            if (str.Contains('_'))
            {
                int i = str.IndexOf('_');
                str = str.Remove(0, str.IndexOf('_') + 1);
            }
                        
            return Regex.Replace(str, @"\d", "");
        }

        public static void GetConfigDel(string[] config, List<string> list)
        {

        }

        public static void GetConfigAdd(string[] config, List<string> list)
        {

        }
    }
}
