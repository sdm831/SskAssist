using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SskAssistWF
{
    public static class Parse
    {
        public static SortedSet<Server> GetListServers(string[] conf)
        {
            SortedSet<Server> servers = new SortedSet<Server>();

            var serverNames = GetListObjects(conf, " serverName=", "status");
            
            foreach(var item in serverNames)
            {
                servers.Add(new Server(item));
            }

            foreach (var server in servers)
            {

                server.Apps = Parse.GetListObjects(conf, " appName=", server.Name);
                server.Queues = Parse.GetListObjects(conf, " queueName=", server.Name);
                server.Endpoints = Parse.GetListObjects(conf, "template=\"EndPoint", server.Name, true);
                server.DataSources = Parse.GetListObjects(conf, " dsName=", server.Name);
            }

            return servers;
        }

        public static SortedSet<string> GetListObjects(string[] configFull, string typeObj, string keyWord)
        {
            SortedSet<string> listObjects = new SortedSet<string>();

            if (typeObj.Contains("queue"))
            {
                keyWord = keyWord.ToLower().TrimPrefDig().Replace("server", "cluster");
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
                        if (!listObjects.Any(s => s.Contains(objName.TrimPrefDig())) && !objName.TrimPrefDig().ToLower().Contains("odr"))
                        {
                            listObjects.Add(objName);
                        }
                    }
                }
            }
            return listObjects;
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

        public static string TrimPrefDig(this string str)
        {
            if (str.Contains('_'))
            {
                int i = str.IndexOf('_');
                str = str.Remove(0, str.IndexOf('_') + 1);
            }
                        
            return Regex.Replace(str, @"\d", "");
        }

        public static string[] GetConfigDel(string[] config, SortedDictionary<string, Server> dictStend)
        {            
            var list = new List<string>();
            var lineAdd = true;

            foreach(var line in config)
            {
                foreach(var server in dictStend)
                {
                    foreach(var v in server.Value.Apps)
                    {   
                        if (line.Contains(v) 
                            && line.Contains(server.Key.TrimPrefDig())
                            && line.Contains("appName="))
                        {
                            lineAdd = false;
                            break;
                        }                        
                    }
                    foreach (var v in server.Value.Queues)

                    {
                        if (line.Contains(v)
                            && line.Contains(server.Key.Replace("Server", "Cluster").TrimPrefDig())
                            && line.Contains("queueName="))
                        {
                            lineAdd = false;
                            break;
                        }
                    }
                    
                    foreach (var v in server.Value.Endpoints)
                    {
                        if (line.Contains(v)
                            && line.Contains(server.Key.TrimPrefDig()))
                        {
                            lineAdd = false;
                            break;
                        }
                    }

                    foreach (var v in server.Value.DataSources)
                    {
                        if (   line.Contains(v)
                            && line.Contains(server.Key.TrimPrefDig())
                            && line.Contains("dsName="))
                        {
                            lineAdd = false;
                            break;
                        }
                    }
                    if (lineAdd == false)
                    {
                        break;
                    }
                }

                if(lineAdd == true)
                {
                    list.Add(line);                    
                }
                
                lineAdd = true;                
            }
            return list.ToArray();
        }

        public static SortedSet<Server> GetServersUnicObjs(SortedSet<Server> prodAll, SortedSet<Server> stendAll)
        {
            SortedSet<Server> prodUnic = new SortedSet<Server>();
            
            foreach (var itemProd in prodAll)
            {
                foreach (var itemStend in stendAll)
                {
                    if (itemProd.Name.TrimPrefDig().ToLower() == itemStend.Name.TrimPrefDig().ToLower())
                    {
                        Server server = new Server(itemProd.Name);
                        
                        server.Apps = GetListUnicObjs(itemProd.Apps, itemStend.Apps);
                        server.Queues = GetListUnicObjs(itemProd.Queues, itemStend.Queues);
                        server.Endpoints = GetListUnicObjs(itemProd.Endpoints, itemStend.Endpoints);
                        server.DataSources = GetListUnicObjs(itemProd.DataSources, itemStend.DataSources);
                    }
                }
            }
            return prodUnic;
        }

        private static SortedSet<string> GetListUnicObjs(SortedSet<string> objsPro, SortedSet<string> objsStend)
        {
            SortedSet<string> duplicateObjects = new SortedSet<string>();
            var unicList = new SortedSet<string>(objsPro);

            foreach (var itemProd in unicList)
            {
                foreach (var itemStend in objsStend)
                {
                    if (itemProd.TrimPrefDig() == itemStend.TrimPrefDig())
                    {
                        duplicateObjects.Add(itemProd.TrimPrefDig());
                    }
                }
            }

            unicList.RemoveWhere(item => duplicateObjects.Contains(item.TrimPrefDig()));
            return unicList;
        }

        //public static void RemoveDublicates(SortedDictionary<string, Server> dictPro, SortedDictionary<string, Server> dictSst)
        //{
        //    foreach (var itemDictPro in dictPro)
        //    {
        //        foreach (var itemDictSst in dictSst)
        //        {
        //            if (itemDictPro.Key.TrimPrefDig().ToLower() == itemDictSst.Key.TrimPrefDig().ToLower())
        //            {
        //                RmObjects(itemDictPro.Value.Apps, itemDictSst.Value.Apps);
        //                RmObjects(itemDictPro.Value.Queues, itemDictSst.Value.Queues);
        //                RmObjects(itemDictPro.Value.Endpoints, itemDictSst.Value.Endpoints);
        //                RmObjects(itemDictPro.Value.DataSources, itemDictSst.Value.DataSources);
        //            }
        //        }
        //    }
        //}




    }
}
