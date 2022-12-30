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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
