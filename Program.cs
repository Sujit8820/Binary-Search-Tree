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
            operation.Insert(56);
            operation.Insert(30);
            operation.Insert(70);
            operation.Insert(22);
            operation.Insert(40);
            operation.Insert(60);
            operation.Insert(95);
            operation.Insert(11);
            operation.Insert(65);
            operation.Insert(3);
            operation.Insert(16);
            operation.Insert(63);
            operation.Insert(67);

            operation.SizeOfTree();
            operation.SearchNode(3);








        }
    }
}
