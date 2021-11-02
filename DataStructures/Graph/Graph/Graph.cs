using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private int _V;
        public LinkedList<int>[] _obj; //obj reps the vertices. Each vertex is a linkedlist

        public Graph(int V) 
        {
            //create
            _obj = new LinkedList<int>[V];
            for(int i = 0; i < _obj.Length; i++) 
            {
                _obj[i] = new LinkedList<int>();
            }

            _V = V;
        }

        public void AddEdges(int u, int v) 
        {
            _obj[u].AddLast(v);
            //_obj[v].AddLast(u);
        }

        public void PrintGraph() 
        {
            for(int i = 0; i < _obj.Length; i++) 
            {
                Console.WriteLine($"Vertex {i} ");
                
                Console.Write("head -> ");

                foreach (var item in _obj[i])
                {
                    Console.Write(item + "->");
                }
                Console.WriteLine();
            }
        }

        public void BFS(int s) 
        {
            //create a boolean array to keep track of the items that have been visited. The array should have the same length 
            //as the no. of vertices
            bool[] visited = new bool[_V];
            
            Queue<int> queue = new Queue<int>();
            
            //Add the starting position to the queue 
            queue.Enqueue(s);

            //use a while loop to check if the queue is empty
            while (queue.Count > 0) 
            {
                //if the queue is greater than zero, assign the first element in the queue to a variable
                int firstElement = queue.Peek();
                //remove the first element from the queue
                queue.Dequeue();

                //check the visited array...if the status of the first element is false, 
                if (!visited[firstElement]) 
                {
                    Console.Write(firstElement + " ");
                    //set first element to true (meaning that we've visited it since we've added and removed it from the queue)
                    visited[firstElement] = true;
                }

                //in the obj array of linkedlists, iterate through the data in each linkedlist of firstElement
                foreach(var item in _obj[firstElement]) 
                {
                    //if the data in visited is false
                    if (!visited[item]) 
                    {
                        //add the item to the queue
                        queue.Enqueue(item);
                    }
                }
            }
            {

            }

        }


    }
}
