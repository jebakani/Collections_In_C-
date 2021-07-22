using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ListDemo
    {
        //method to display the list functions
        public static void ExecuteList()
        {
            Console.WriteLine("Creating list");
            List<string> list = new List<string>();
            list.Add("abc");
            list.Add("tvs");
            list.Add("xyz");
            list.Add("BridgeLabz");
            Console.WriteLine("Displaying the list items");
            DisplayList(list);
            Console.WriteLine("\nRemove the element");
            list.Remove("xyz");
            Console.WriteLine("After removal");
            DisplayList(list);
            Console.WriteLine("\nElement at 2nd position is {0}", list[2]);


        }
        //Method to display the list
        public static void DisplayList(List<string> list)
        {
            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
        }
    }
}
