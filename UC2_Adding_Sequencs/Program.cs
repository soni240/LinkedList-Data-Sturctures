// See https://aka.ms/new-console-template for more information
using System;

namespace UC2_Adding_Sequencs
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase 1
            Operation obj = new Operation();
            //Insertion Operation
            obj.InsertFront(56);
            obj.InsertFront(30);
            obj.InsertFront(70);
            //Display Operation
            Console.WriteLine("*****Insertion at First*****");
            obj.Display();
        }
    }
}
