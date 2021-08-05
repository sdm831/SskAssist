using System.Collections.Generic;
using System.IO;

namespace SskAssistWF
{
    public static class Print
    {
        public static void PrintServers(this SortedSet<string> hs, string keyWord, string path)
        {            
            if (!Directory.Exists("configs"))
            {
                Directory.CreateDirectory("configs");
            } 

            File.AppendAllText(path, $"{keyWord} Servers: {hs.Count}\n");
            
            foreach (var v in hs)
            {                
                File.AppendAllText(path, $"    {v}\n");
            }
            File.AppendAllText(path, $"\n");
        }
        
        public static void PrintAllObj(this SortedDictionary<string, Server> dict, string path, string keyWord)
        {
            PrintHead(dict, path, keyWord);
            File.AppendAllText(path, $"\n");
        }

        private static void PrintHead(SortedDictionary<string, Server> dict, string path, string keyWord)
        {
            File.AppendAllText(path, $" ##########################################################\n");
            File.AppendAllText(path, $"                   {keyWord} objects:                      \n");      // вывод статуса объектов
            File.AppendAllText(path, $" ##########################################################\n\n");
            
            foreach (var v in dict)
            {
                if (v.Value.Apps.Count != 0 || v.Value.DataSources.Count != 0 || v.Value.Queues.Count != 0 || v.Value.Endpoints.Count != 0)
                {
                    File.AppendAllText(path, $"{v.Key}:\n\n");                                // вывод имени сервера
                    PrintType(v.Value.Apps, "Applications", path);
                    PrintType(v.Value.DataSources, "Datasources", path);
                    PrintType(v.Value.Endpoints, "Endpoints", path);
                    PrintType(v.Value.Queues, "Queues", path);
                }
                else
                {
                    var a = !keyWord.Contains("Added");
                    var d = !keyWord.Contains("Deleted");

                    if (!keyWord.Contains("Added") && !keyWord.Contains("Deleted"))
                    {
                        File.AppendAllText(path, $"{v.Key}: does not have objects!\n\n");
                    }
                    
                }
            }
            File.AppendAllText(path, $"\n");
        }

        private static void PrintType(SortedSet<string> items, string keyWord, string path)
        {
            if (items.Count != 0)
            {
                File.AppendAllText(path, $"    {keyWord}: {items.Count}\n");
                PrintItems(items, path);
            }
        
        }

        private static void PrintItems(SortedSet<string> items, string path)
        {
            foreach (var item in items)
            {
                File.AppendAllText(path, $"        {item}\n");
            }
            File.AppendAllText(path, $"\n");
        }

        public static void PrintConfig(string[] config, SortedSet<string> list)
        {

        }
    }
}
