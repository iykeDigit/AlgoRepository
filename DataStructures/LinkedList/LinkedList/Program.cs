using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //Console.WriteLine(list.IsEmpty());
            list.InsertAtHead(3);
            list.InsertAtHead(4);
            list.InsertAtHead(4);
            list.InsertAtHead(5);
            list.InsertAtHead(4);
            list.InsertAtHead(1);
            list.InsertAtHead(2);

            list.PrintList();

            list.RemoveDuplicates();

            list.PrintList();

            Console.WriteLine();

           

        }
    }
}
