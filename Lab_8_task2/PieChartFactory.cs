namespace Lab_8_task2
{
    public class PieChartFactory: GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new PieChart();
        }
    }
}