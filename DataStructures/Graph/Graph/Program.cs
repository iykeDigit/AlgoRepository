using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(9);   //reps the no of vertices
            graph.AddEdges(0, 1);
            graph.AddEdges(0, 2);
            graph.AddEdges(1, 2);
            graph.AddEdges(1, 5);
            graph.AddEdges(2, 3);
            graph.AddEdges(2, 4);
            graph.AddEdges(2, 5);
            graph.AddEdges(2, 6);
            graph.AddEdges(3, 4);
            graph.AddEdges(3,6);
            graph.AddEdges(3, 7);
            graph.AddEdges(4, 6);
            graph.AddEdges(4, 7);
            graph.AddEdges(5,6);
            graph.AddEdges(5, 8);
            graph.AddEdges(6,7);
            graph.AddEdges(6,8);

            graph.PrintGraph();

            //graph.BFS(0);
        }
    }
}
