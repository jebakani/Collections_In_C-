using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class StackDemo
    {
        //method to execute stack
        public static void ExecuteStack()
        {
            Console.WriteLine("Creating Stack");
            Stack<int> stack = new Stack<int>();
            //method to insert the element
            stack.Push(10);
            stack.Push(11);
            stack.Push(20);
            stack.Push(1);
            stack.Push(100);
            //returns the stop element in the stack
            Console.WriteLine("Peeking element at top :{0}",stack.Peek());
            Console.WriteLine("\nRemove the element");
            //delete the top element
            stack.Pop();
            Console.WriteLine("Total number of element in stack:{0}",stack.Count());
        }
    }
}
