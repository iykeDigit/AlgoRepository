using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            LinkedList list_two = new LinkedList();
            //Console.WriteLine(list.IsEmpty());
         
            list_two.InsertAtHead(19);
            list_two.InsertAtHead(20);
            list_two.InsertAtHead(5);
            list_two.InsertAtHead(7);
            list_two.InsertAtHead(35);
            list_two.PrintList();

            var x = LinkedList.FindNth(list_two, 4);

            Console.WriteLine();
            

           

        }
    }
}
