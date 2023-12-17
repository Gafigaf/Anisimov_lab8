using System;

namespace Lab_8_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of device you want to create (smartphone, laptop, tablet):");
            string deviceType = Console.ReadLine();

            IDeviceFactory factory = null;
            switch (deviceType.ToLower())
            {
                case "smartphone":
                    factory = new SmartphoneFactory();
                    break;
                case "laptop":
                    factory = new LaptopFactory();
                    break;
                case "tablet":
                    factory = new TabletFactory();
                    break;
                default:
                    Console.WriteLine("Invalid device type.");
                    return;
            }

            IScreen screen = factory.CreateScreen();
            IProcessor processor = factory.CreateProcessor();
            ICamera camera = factory.CreateCamera();

            Console.WriteLine("Created a new device with the following components:");
            screen.Display();
            processor.Process();
            camera.TakePhoto();
        }
    }
}