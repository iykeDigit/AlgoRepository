using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class SinglyLinkedList<T>
    {
        private Node<T> head;

        public SinglyLinkedList()
        {
            head = null;
        }


        public void AddToFront(T data) 
        {
            Node<T> temp = new Node<T>(data);
            temp.NextItem = head;
            head = temp;
        }


        public void AddToBack(T data) 
        {
            Node<T> currentNode = new Node<T>(data);
            Node<T> node = head;
            if (node == null) 
            {
                head = currentNode;
            }
            while (node != null) 
            {
                if (node.NextItem == null) 
                {
                    node.NextItem = currentNode;
                    break;
                }
                node = node.NextItem;
            }
           
        }



        /// <summary>
        /// Display all elements in the list
        /// </summary>
        public void DisplayList() 
        {
            Node<T> p;
            if(head == null) 
            {
                Console.WriteLine("The list is empty");
                return;
            }
            Console.WriteLine("List is : ");
            p = head;
            while(p != null) 
            {
                Console.WriteLine(p.info + " ");
                p = p.NextItem;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Display the number of nodes in the list
        /// </summary>
        public void CountNodes() 
        {
            int n = 0;
            Node<T> p = head;
            while(p != null) 
            {
                n++;
                p = p.NextItem;
            }
            Console.WriteLine("Number of nodes in the list is {n}");
        }

        /// <summary>
        /// Check if an element is present in the list
        /// </summary>
        public bool Search(T x) 
        {
            int position = 1;
            Node<T> p = head;
            while(p != null) 
            {
                if (p.Equals(x))
                {
                    break;
                }
                    
                position++;
                p = p.NextItem;
            }

            if(p == null) //if the first node is empty, the list is empty
            {
                Console.WriteLine($"{x} isn't found in the list");
                return false;
            }
            else 
            {
                Console.WriteLine($"{x} is at position {position}");
                return true;
            }

        }

        
    }
}
