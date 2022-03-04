using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Operation
    {
        public Node root;
        public void InsertAndDisplay(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                Console.WriteLine($" root: {node.data}");
            }

            else if (node.data < root.data)
            {
                root.left = node;
                Console.WriteLine($" left: {node.data}");
            }

            else
            {
                root.right = node;
                Console.WriteLine($" right: {node.data}");
            }
        }





    }

}



   
