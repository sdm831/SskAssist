using System.Collections.Generic;

namespace SskAssistWF
{
    public class Server
    {
        //public string Name { get; set; }

        public SortedSet<string> Apps = new SortedSet<string>();
        public SortedSet<string> Queues = new SortedSet<string>();
        public SortedSet<string> Endpoints = new SortedSet<string>();
        public SortedSet<string> DataSources = new SortedSet<string>();

                //public HashSet<string> EndPoints = new HashSet<string>();
        public Server (string name, string[] configFull)
        {
            //Name = name;
            Apps = Parse.GetListObjects(configFull, " appName=", name);
            Queues = Parse.GetListObjects(configFull, " queueName=", name);
            Endpoints = Parse.GetListObjects(configFull, "template=\"EndPoint", name, true);
            DataSources = Parse.GetListObjects(configFull, " dsName=", name);
        }
    }
}
