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
        public int rightCount = 0;
        public  int leftCount = 0;
        public void Insert(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                Console.WriteLine($" root is : {node.data}");

            }

            else
            {
                Node p = root;
                bool isAdded = false;
                while(isAdded != true)
                { 
                
                    if (p.data < data)
                    {
                        if(p.right == null)
                        {
                            p.right = node;
                            isAdded = true;
                            Console.WriteLine($"{node.data} is added to right side of {p.data}");
                            rightCount++;
                            break;
                        }
                        p = p.right;
                    }
                    if(p.data > data)
                    {
                        if(p.left == null)
                        {
                            p.left = node;
                            isAdded |= true;
                            Console.WriteLine($"{node.data} is added to left side of {p.data}");
                            leftCount++;
                            break;
                        }
                        p = p.left;
                    }
                }
            }

           
        }
        public  void SizeOfTree()
        {
            int size = rightCount + leftCount +1;
            Console.WriteLine($"\nSize of tree is {size}");
        }





    }

}



   
