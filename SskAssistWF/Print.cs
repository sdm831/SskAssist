using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System;
using Newtonsoft.Json;


namespace SskAssistWF
{
    public static class Print
    {
        public static Encoding ISO88595 { get; set; } = Encoding.GetEncoding(28595);

        public static void CheckDir(string pth)
        {
            if (!Directory.Exists(pth))
            {
                Directory.CreateDirectory(pth);
            }
        }
        
        public static void PrintServers(this SortedSet<string> hs, string keyWord, string path)
        {               
            File.AppendAllText(path, $"{keyWord} Servers: {hs.Count}\n");
            
            foreach (var v in hs)
            {                
                File.AppendAllText(path, $"    {v}\n", Print.ISO88595);
            }
            File.AppendAllText(path, $"\n", Print.ISO88595);
        }

        public static void PrintAllObj(this SortedSet<Server> servers, string path, string keyWord)
        {
            PrintHead(servers, path, keyWord);
            File.AppendAllText(path, $"\n", Print.ISO88595);
        }
                
        private static void PrintHead(SortedSet<Server> servers, string path, string keyWord)
        {
            File.AppendAllText(path, $" ##########################################################\n",   Print.ISO88595);
            File.AppendAllText(path, $"                   {keyWord} objects:                      \n",   Print.ISO88595);      // вывод статуса объектов
            File.AppendAllText(path, $" ##########################################################\n\n", Print.ISO88595);

            foreach (var v in servers)
            {
                if (v.Apps.Count != 0 || v.DataSources.Count != 0 || v.Queues.Count != 0 || v.Endpoints.Count != 0)
                {
                    File.AppendAllText(path, $"{v.Name}:\n\n", Print.ISO88595);                                // вывод имени сервера
                    PrintType(v.Apps, "Applications", path);
                    PrintType(v.DataSources, "Datasources", path);
                    PrintType(v.Endpoints, "Endpoints", path);
                    PrintType(v.Queues, "Queues", path);
                }
                else
                {
                    var a = !keyWord.Contains("Added");
                    var d = !keyWord.Contains("Deleted");

                    if (!keyWord.Contains("Added") && !keyWord.Contains("Deleted"))
                    {
                        File.AppendAllText(path, $"{v.Name}: does not have objects!\n\n", Print.ISO88595);
                    }

                }
            }
            File.AppendAllText(path, $"\n", Print.ISO88595);
        }
                
        private static void PrintType(SortedSet<string> items, string keyWord, string path)
        {
            if (items.Count != 0)
            {
                File.AppendAllText(path, $"    {keyWord}: {items.Count}\n", Print.ISO88595);
                PrintItems(items, path);
            }
        
        }

        private static void PrintItems(SortedSet<string> items, string path)
        {
            foreach (var item in items)
            {
                File.AppendAllText(path, $"        {item}\n", Print.ISO88595);
            }
            File.AppendAllText(path, $"\n", Print.ISO88595);
        }

        public static void PrintConfig(string[] config, string path)
        {
            foreach(var line in config)
            {                
                File.AppendAllText(path, $"{line}\n", Print.ISO88595);
            }
        }

        public static void PrintList(List<string> responce)
        {
            string str = "";
            foreach (var v in responce)
            {
                str += $"{v}\n";
            }
            MessageBox.Show(str);
        }

               
    }
}
