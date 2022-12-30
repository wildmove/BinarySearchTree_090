using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_090
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
        
    }

    /* A Node class consists of three thins the information, reference to the right child, and reference to the left child*/

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; //Initialize ROOT as null
        }
        public void insert(string element) //Insert a node in the binary tree
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else // If the specified node is not present
            {
                tmp = new Node(element, null, null); //create a Node
                if (parent == null)
                {
                    ROOT= tmp;
                }
                else if (string.Compare(element, parent.info) < 0) 
                {
                    parent.leftchild= tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
