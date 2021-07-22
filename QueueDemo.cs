using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class QueueDemo
    {
        //executing the queue 
        public static void ExecuteQueue()
        {
            Console.WriteLine("Creating queue");
            Queue<string> queue = new Queue<string>();
            //method to add element into the queue
            queue.Enqueue("abc");
            queue.Enqueue("xyz");
            queue.Enqueue("aaa");
            queue.Enqueue("bbb");
            queue.Enqueue("ccc");
            Console.WriteLine("\nDisplaying the queue");
            foreach(string q in queue )
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("Removing the element");
            //method to remove element from the queue
            queue.Dequeue();
            Console.WriteLine("\nDisplaying the queue");
            foreach (string q in queue)
            {
                Console.WriteLine(q);
            }

        }
    }
}
