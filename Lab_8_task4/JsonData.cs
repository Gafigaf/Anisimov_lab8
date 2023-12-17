using System;

namespace Lab_8_task4
{
    public class JsonData: IDataPrototype
    {
        public string JsonProperty1 { get; set; }
        public string JsonProperty2 { get; set; }

        public IDataPrototype Clone()
        {
            return MemberwiseClone() as IDataPrototype;
        }

        public void FillData()
        {
            Console.WriteLine("Enter JSON data:");
            JsonProperty1 = Console.ReadLine();
            JsonProperty2 = Console.ReadLine();
        }
    }
}