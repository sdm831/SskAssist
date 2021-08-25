using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                        if (!listObjects.Any(s => s.Contains(objName)) && !objName.TrimPrefDig().ToLower().Contains("odr"))
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

        public static string[] GetConfigDel(string[] configArr, SortedSet<Server> serversList)
        {            
            var list = new List<string>();
            var lineAdd = true;

            foreach(var line in configArr)
            {
                foreach(var server in serversList)
                {
                    foreach(var v in server.Apps)
                    {   
                        if (line.Contains(v) 
                            && line.Contains(server.Name.TrimPrefDig())
                            && line.Contains("appName="))
                        {
                            lineAdd = false;
                            break;
                        }                        
                    }
                    foreach (var v in server.Queues)

                    {
                        if (line.Contains(v)
                            && line.Contains(server.Name.Replace("Server", "Cluster").TrimPrefDig())
                            && line.Contains("queueName="))
                        {
                            lineAdd = false;
                            break;
                        }
                    }
                    
                    foreach (var v in server.Endpoints)
                    {
                        if (line.Contains(v)
                            && line.Contains(server.Name.TrimPrefDig()))
                        {
                            lineAdd = false;
                            break;
                        }
                    }

                    foreach (var v in server.DataSources)
                    {
                        if (   line.Contains(v)
                            && line.Contains(server.Name.TrimPrefDig())
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
        
        public static string[] GetConfigAdd(string[] configArr, SortedSet<Server> serversList)
        {
            var newConfig = new List<string>();
            var addedList = new List<string>();            
            var currentServer = "";
            
            // перебор строк
            foreach (var line in configArr)
            {
                if (line.Contains("serverName=") || line.Contains("appName=") || line.Contains("dsName=") || line.Contains("queueName=") || line.ToLower().Contains("endpoint"))
                {
                    currentServer = GetServerName(line);


                    // перебор серверов
                    foreach (var server in serversList)
                    {
                        // перебор приложений
                        var appTag = "appName=";
                        foreach (var app in server.Apps)
                        {
                            if (line.Contains(server.Name.TrimPrefDig()) && line.Contains(appTag))
                            {
                                var tmp2 = !addedList.Contains(currentServer);
                                var tmp3 = GetSubstringReplace(line, "appName=");

                                if (!addedList.Contains($"{currentServer},{app}"))
                                {
                                    newConfig.Add(line.Replace(GetSubstringReplace(line, appTag), app));
                                    addedList.Add($"{currentServer},{app}");
                                }
                            }
                        }

                        // перебор datasources
                        var dsTag = "dsName=";
                        foreach (var ds in server.DataSources)
                        {
                            if (line.Contains(server.Name.TrimPrefDig()) && line.Contains(dsTag))
                            {

                                var tmp2 = !addedList.Contains(currentServer);
                                var tmp3 = GetSubstringReplace(line, dsTag);

                                if (!addedList.Contains($"{currentServer},{ds}"))
                                {
                                    newConfig.Add(line.Replace(GetSubstringReplace(line, dsTag), ds));
                                    addedList.Add($"{currentServer},{ds}");
                                }
                            }
                        }
                    }
                }

                newConfig.Add(line);                
            }
            return newConfig.ToArray();
        }

        private static string GetServerName(string line)
        {
            int resultFindStart = line.IndexOf("Server=");
            if (resultFindStart != -1)
            {
                int point1 = line.IndexOf('=', resultFindStart) + 1;
                int point2 = line.IndexOf(',', point1);

                try
                {
                    return line.Substring(point1, point2 - point1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        public static string GetSubstringReplace(this string line, string keyWord)
        {
            int resultFindStart = line.IndexOf(keyWord);
            if (resultFindStart != -1)
            {
                int point1 = line.IndexOf('"', resultFindStart) + 1;
                int point2 = line.IndexOf('"', point1);

                return line.Substring(point1, point2 - point1);
            }
            return null;
        }

        public static SortedSet<Server> GetServersUnicObjs(SortedSet<Server> serversList1, SortedSet<Server> ServersList2)
        {
            SortedSet<Server> serverList1Unic = new SortedSet<Server>();
            
            foreach (var server1 in serversList1)
            {
                var v = !ServersList2.Contains(server1);
                if (!ServersList2.Contains(server1))
                {
                    serverList1Unic.Add(server1);
                    continue;
                }
                
                foreach (var server2 in ServersList2)
                {
                    if (server1.Name.TrimPrefDig().ToLower() == server2.Name.TrimPrefDig().ToLower())
                    {
                        Server server = new Server(server1.Name);
                        
                        server.Apps        = GetListUnicObjs(server1.Apps,        server2.Apps);
                        server.Queues      = GetListUnicObjs(server1.Queues,      server2.Queues);
                        server.Endpoints   = GetListUnicObjs(server1.Endpoints,   server2.Endpoints);
                        server.DataSources = GetListUnicObjs(server1.DataSources, server2.DataSources);


                        if (server.Apps.Count != 0 ||
                            server.Queues.Count != 0 ||
                            server.Endpoints.Count != 0 ||
                            server.DataSources.Count != 0
                            )
                        {
                            serverList1Unic.Add(server);
                        }
                    }                    
                }
            }            
            return serverList1Unic;
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
