using System;

namespace Lab_8_task4
{
    public class XmlData: IDataPrototype
    {
        public string XmlElement1 { get; set; }
        public string XmlElement2 { get; set; }

        public IDataPrototype Clone()
        {
            return MemberwiseClone() as IDataPrototype;
        }
        public void FillData()
        {
            Console.WriteLine("Enter XML data:");
            XmlElement1 = Console.ReadLine();
            XmlElement2 = Console.ReadLine();
        }
    }
}