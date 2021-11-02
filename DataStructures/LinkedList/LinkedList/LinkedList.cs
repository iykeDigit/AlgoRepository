﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node 
    {
        public int Data;
        public Node Next;

        public Node()
        {
            Next = null;
        }
    }
    public class LinkedList
    {
        private Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public bool IsEmpty() 
        {
            if (Head == null) 
            {
                return true;
            }
            return false;
        }

        public void InsertAtHead(int value) 
        {
            Node node = new Node();
            node.Data = value;
            node.Next = Head;
            Head = node;
        }

        public bool PrintList() 
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("List is empty");
                return false;
            }

            Node temp = Head;
            Console.WriteLine("List : ");

            while (temp != null) 
            {
                Console.Write($"{temp.Data} ->");
                temp = temp.Next;
            }
            Console.WriteLine("null");
            return true;
        }

        public void InsertAtTail(int value) 
        {
            Node newNode = new Node();
            newNode.Data = value;
            Node current = Head;
            if (current == null) //list is empty
            {
                Head = newNode;
            }

            while (current != null) //while we're not at the end
            {
                if (current.Next == null) 
                {
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }

        public void InsertAtNthPosition(int value, int position) 
        {
            int count = 0;
            Node newNode = new Node();
            newNode.Data = value;
            Node currentNode = Head;
            Node previousNode = new Node();
            while(count != position) 
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                
                count++;
            }
            previousNode.Next = newNode;
            newNode.Next = currentNode;
            }

        public bool Search(int value)
        {
            Node currentNode = Head;
            if (Head == null) 
            {
                return false;
            }

            else 
            {
                while (currentNode.Next != null) 
                {
                    if(currentNode.Data == value) 
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
            }
            return false; 
        }

        public void DeleteAtHead() 
        {
            if(Head != null)
                Head = Head.Next;
        }

        public bool Delete(int value)
        {
            Node currentNode = Head;
            Node previousNode = new Node();
            
            
            if(currentNode == null) 
            {
                return false;
            }

            if(Head.Data == value) 
            {
                Head = Head.Next;
                return true;
            } 

            while (currentNode.Next != null) 
            {
                if(currentNode.Data == value) 
                {
                    previousNode.Next = currentNode.Next;
                    currentNode = previousNode.Next;
                    return true;
                    
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public int Length()
        {
            int count = 0;
            // Write your code here
            Node currentNode = Head;
           
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }
            return count;
        }

        /// <summary>
        /// reverse a linked list. Time complexity is O(n), space is O(1)
        /// </summary>
        public void Reverse() 
        {
            Node previous = null;
            Node next = null;
            Node current = Head;

            while(current != null)//while we haven't gotten to the end
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;//cuz we need to transverse the entire list
            }

            //set the previous element as the head
            Head = previous;
        }

        public bool DetectLoop()
        {
            Node slow = Head, fast = Head;

            while ((slow != null) && (fast != null) && (fast.Next != null)) 
            {
                slow = slow.Next; //move one step
                fast = fast.Next.Next; //move two steps

                //if slow and fast meet at some point then there is a loop
                if(slow == fast) 
                {
                    return true;
                }
            }
            return false; //no loop
        }

        /// <summary>
        /// Find the middle node of a 
        /// </summary>
        /// <returns></returns>
        public int FindMidNode() 
        {
            Node midNode = Head;
            Node currentNode = Head;

            if (currentNode.Next == null) 
            {
                return currentNode.Data;
            }

            while (currentNode != null && currentNode.Next != null ) 
            {
                midNode = midNode.Next;
                currentNode = currentNode.Next.Next;
            }

            return midNode.Data;
        }

        public void RemoveDuplicates()
        {
            HashSet<int> list = new HashSet<int>();
            Node currentNode = Head;
            Node previous = null;

            while (currentNode != null) 
            {
                if (list.Contains(currentNode.Data)) 
                {
                    previous.Next= currentNode.Next;
                    currentNode = previous.Next;
                }

                else 
                {
                    list.Add(currentNode.Data);
                    previous = currentNode;
                    currentNode = previous.Next;

                }
                
                
                
                
            }

                
            }

           
        }

    }

