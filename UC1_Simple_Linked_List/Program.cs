// See https://aka.ms/new-console-template for more information
using System;

namespace UC1_Simple_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase 1
            Operation obj = new Operation();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertLast(30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*****Insertion at Last*****");
            obj.Display();
        }
    }
}

