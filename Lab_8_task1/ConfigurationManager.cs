using System;

namespace Lab_8_task1
{
    public sealed class ConfigurationManager
    {
        private static readonly ConfigurationManager instance = new ConfigurationManager();

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void SaveConfiguration(string configuration)
        {
            Console.WriteLine("Configuration saved: " + configuration);
        }

        public void ChangeConfiguration(string configuration)
        {
            Console.WriteLine("Configuration changed: " + configuration);
        }
    }
}