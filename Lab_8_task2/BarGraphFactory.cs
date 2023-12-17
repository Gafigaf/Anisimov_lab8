namespace Lab_8_task2
{
    public class BarGraphFactory: GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new BarGraph();
        }
    }
}