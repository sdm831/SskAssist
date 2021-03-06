using System.Collections.Generic;
using System.Linq;

namespace SskAssistWF
{
    public static class ComparerObjects
    {
        public static void RemoveDublicates(SortedDictionary<string, Server> dictPro, SortedDictionary<string, Server> dictSst)
        {            
            foreach (var itemDictPro in dictPro)
            {
                foreach (var itemDictSst in dictSst)
                {
                    if (itemDictPro.Key.TrimPrefDig().ToLower() == itemDictSst.Key.TrimPrefDig().ToLower())
                    {
                        RmObjects(itemDictPro.Value.Apps,        itemDictSst.Value.Apps);
                        RmObjects(itemDictPro.Value.Queues,      itemDictSst.Value.Queues);
                        RmObjects(itemDictPro.Value.Endpoints,   itemDictSst.Value.Endpoints);
                        RmObjects(itemDictPro.Value.DataSources, itemDictSst.Value.DataSources);
                    }
                }
            }
        }

        public static void RmObjects(SortedSet<string> objsPro, SortedSet<string> objsSst)
        {
            SortedSet<string> duplicateObjects = new SortedSet<string>();

            foreach (var itemListPro in objsPro)
            {
                foreach (var itemListSst in objsSst)
                {
                    if (itemListPro.TrimPrefDig() == itemListSst.TrimPrefDig())
                    {
                        duplicateObjects.Add(itemListPro.TrimPrefDig());
                    }
                }
            }
            
            objsPro.RemoveWhere(item => duplicateObjects.Contains(item.TrimPrefDig()));
            objsSst.RemoveWhere(item => duplicateObjects.Contains(item.TrimPrefDig()));
        }   
    }
}
