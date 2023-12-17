namespace Lab_8_task2
{
    public class LineGraphFactory: GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new LineGraph();
        }
    }
}