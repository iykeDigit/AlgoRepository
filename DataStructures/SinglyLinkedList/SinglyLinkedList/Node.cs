using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Node<T>
    {
        public T info;
        public Node<T> NextItem;

        public Node(T i)
        {
            this.info = i;
            this.NextItem = null;
        }

       
    }
}
