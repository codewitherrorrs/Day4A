using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogAssignment
{
    public class DictionaryDemo
    {
        private readonly Nlog nlog = new Nlog();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public void DictMethod()
        {
            dictionary.Add("1", "Sagar");
            dictionary.Add("2", "Shahu");
            dictionary.Add("3", "Shreya Maam");
            dictionary.Add("4", "Krishna");
            foreach (KeyValuePair<string, string> key in dictionary)
            {
                Console.WriteLine("{0} : {1}", key.Key, key.Value);
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {key.Key}{key.Value}");
            }
            nlog.LogDebug("Debug Successfully");
            //Remove the value.
            dictionary.Remove("3");
            foreach (KeyValuePair<string, string> kv in dictionary)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {kv.Key}{kv.Value}");
            }
            nlog.LogDebug("Debug Successfully");
            //Update Dictionary
            if (dictionary.ContainsKey("2"))
            {
                dictionary["2"] = "Abhishek";
            }
            foreach (KeyValuePair<string, string> kv in dictionary)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {kv.Key}{kv.Value}");
            }
            nlog.LogDebug("Debug Successfully");
            //Clear method is use to clear the dictionary.
            dictionary.Clear();
            foreach (KeyValuePair<string, string> kv in dictionary)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {kv.Key} {kv.Value}");
            }
            nlog.LogDebug("Debug Successfully");
        }
    }
}
