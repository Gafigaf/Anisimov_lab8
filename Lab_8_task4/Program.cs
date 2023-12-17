using System;

namespace Lab_8_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source format (CSV, XML, JSON):");
            string sourceFormat = Console.ReadLine();

            Console.WriteLine("Enter target format (CSV, XML, JSON):");
            string targetFormat = Console.ReadLine();
            
            IDataPrototype sourceData;
            if (sourceFormat.Equals("CSV", StringComparison.OrdinalIgnoreCase))
            {
                sourceData = new CsvData();
            }
            else if (sourceFormat.Equals("XML", StringComparison.OrdinalIgnoreCase))
            {
                sourceData = new XmlData();
            }
            else if (sourceFormat.Equals("JSON", StringComparison.OrdinalIgnoreCase))
            {
                sourceData = new JsonData();
            }
            else
            {
                Console.WriteLine($"Source format '{sourceFormat}' is not supported.");
                return;
            }
            
            sourceData.FillData();
            
            var adapter = new DataFormatAdapter();
            var targetData = adapter.Convert(sourceData, targetFormat);

            Console.WriteLine($"Converted data in {targetFormat} format:");
            Console.WriteLine(targetData);
        }
    }
}