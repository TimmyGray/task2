using task2;
using System;
using System.Diagnostics;
using System.Text;

namespace task2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            GraphMaker graphMaker = new GraphMaker(data);
            graphMaker.DrowGraph();
            
        }
    }

}
