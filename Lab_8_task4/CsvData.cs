using System;

namespace Lab_8_task4
{
    public class CsvData: IDataPrototype
    {
        public string CsvField1 { get; set; }
        public string CsvField2 { get; set; }

        public IDataPrototype Clone()
        {
            return MemberwiseClone() as IDataPrototype;
        }

        public void FillData()
        {
            Console.WriteLine("Enter CSV data:");
            CsvField1 = Console.ReadLine();
            CsvField2 = Console.ReadLine();
        }
    }
}