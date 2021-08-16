using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SskAssistWF
{
    public class Server : IComparable<Server>
    {
        [JsonProperty(Order = 1)]
        public string Name { get; set; }
        [JsonProperty(Order = 2)]
        public SortedSet<string> Apps        = new SortedSet<string>();
        [JsonProperty(Order = 3)]            
        public SortedSet<string> Endpoints   = new SortedSet<string>();
        [JsonProperty(Order = 4)]
        public SortedSet<string> DataSources = new SortedSet<string>();
        [JsonProperty(Order = 5)]
        public SortedSet<string> Queues      = new SortedSet<string>();
                
        public Server(string name)
        {
            Name = name;            
        }

        public int CompareTo(Server other)
        {
            return Name.CompareTo(other.Name);
        }  
    }
}
