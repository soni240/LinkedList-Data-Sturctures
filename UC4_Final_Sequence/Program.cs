// See https://aka.ms/new-console-template for more information

using System;

namespace UC4_Final_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase 1
            Operation obj = new Operation();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertBetween(2, 30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*****Appending*****");
            obj.Display();
        }
    }
}
