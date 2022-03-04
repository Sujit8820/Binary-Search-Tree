// See https://aka.ms/new-console-template for more information
using System;
namespace Binary_Search_Tree
{
    class program
    {
        public static void  Main(string[] args)
        {
            Console.WriteLine("Wellcome to Binary Search Tree");

            Operation operation = new Operation();
            operation.InsertAndDisplay(56);
            operation.InsertAndDisplay(30);
            operation.InsertAndDisplay(70);


        }
    }
}
