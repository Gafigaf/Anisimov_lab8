using System;

namespace Lab_8_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of graph you want to draw (line, bar, pie):");
            string graphType = Console.ReadLine();

            GraphFactory factory = null;
            switch (graphType.ToLower())
            {
                case "line":
                    factory = new LineGraphFactory();
                    break;
                case "bar":
                    factory = new BarGraphFactory();
                    break;
                case "pie":
                    factory = new PieChartFactory();
                    break;
                default:
                    Console.WriteLine("Invalid graph type.");
                    return;
            }

            IGraph graph = factory.CreateGraph();
            graph.Draw();
        }
    }
}