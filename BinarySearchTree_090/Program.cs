using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            search(element, ref parent, ref currentNode);
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
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            //This function seaarches the currentNode of the specified node as well as the current Node of its parent
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, parent.info) < 0)
                    currentNode = currentNode.leftchild;
                else 
                    currentNode= currentNode.rightchild;
            }
        }
        public void inOrder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                inOrder(ptr.leftchild);
                Console.Write(ptr.info);
            }
        }
        public void preOrder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preOrder(ptr.leftchild);
                preOrder(ptr.rightchild);
            }
        }
        public void postOrder(Node ptr) // perform the post order traversal of the tree
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postOrder(ptr.leftchild);
                postOrder(ptr.rightchild);
                Console.Write(ptr.info + " ");
            }
        }
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Perform inOrder traversal");
                Console.WriteLine("3. Perform preOrder traversal");
                Console.WriteLine("4. Perform postOrder traversal");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice (1-5)");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");
                            String word = Console.ReadLine();
                            x.insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.inOrder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preOrder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postOrder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }
            }
        }
    }
}
