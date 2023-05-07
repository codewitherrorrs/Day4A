using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogAssignment
{
    public class ArrayListDemo
    {
        private readonly Nlog nlog = new Nlog();
        public void Method()
        {
            //Declaring ArrayList.
            ArrayList arrayList = new ArrayList();
            //Adding Element into the ArrayList.
            Console.WriteLine("Add Element in ArrayList");
            arrayList.Add(25);
            arrayList.Add(13);
            arrayList.Add(3);
            arrayList.Add(38);
            //Read the ArrayList
            foreach(int i in arrayList)
            {
                Console.WriteLine($"{i}");
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {i}");
            }
            nlog.LogDebug("Debug Successfully");
            //Update the ArrayList.
            Console.WriteLine("Update The ArrayList");
            arrayList.Insert(2, "Sagar");
            arrayList.Insert(1, "Shahu");
            //Read the ArrayList.
            foreach(var i in arrayList)
            {
                Console.WriteLine($"{i}");
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {i}");
            }
            nlog.LogDebug("Debug Successfully");
            //Remove Element or Delete the element ArrayList.
            Console.WriteLine("Remove the Element in ArrayLIst");
            arrayList.Remove(1);
            arrayList.RemoveAt(3);
            foreach(var i in arrayList)
            {
                Console.WriteLine($"{i}");
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarning("Having Null Vaue");
                nlog.LogInfo($"Add Elemnt in ArrayList Successfully : {i}");
            }
            nlog.LogDebug("Debug Successfully");
        }
      
    }
}
