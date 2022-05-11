// See https://aka.ms/new-console-template for more information
using System;

namespace UC3_Append
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase 1
            Operation obj = new Operation();
            //Insertion Operation
            obj.Append(56);
            obj.Append(30);
            obj.Append(70);
            //Display Operation
            Console.WriteLine("*****Appending*****");
            obj.Display();
        }
    }
}


