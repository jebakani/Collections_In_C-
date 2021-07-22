using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection Library");
            Console.WriteLine("1.List");
            Console.WriteLine("2.Stack");
            Console.WriteLine("3.Queue");
            Console.WriteLine("Enter you choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    ListDemo.ExecuteList();
                    break;
                case 2:
                    StackDemo.ExecuteStack();
                    break;
                case 3:
                    QueueDemo.ExecuteQueue();
                    break;
                default:
                    break;
            }
        }
    }
}
