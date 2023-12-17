using System;

namespace Lab_8_task4
{
    public class DataFormatAdapter
    {
        public IDataPrototype Convert(IDataPrototype source, string targetFormat)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (targetFormat.Equals("CSV", StringComparison.OrdinalIgnoreCase))
            {
                var csvData = source.Clone() as CsvData;

                return csvData;
            }
            else if (targetFormat.Equals("XML", StringComparison.OrdinalIgnoreCase))
            {
                var xmlData = source.Clone() as XmlData;

                return xmlData;
            }
            else if (targetFormat.Equals("JSON", StringComparison.OrdinalIgnoreCase))
            {
                var jsonData = source.Clone() as JsonData;

                return jsonData;
            }
            else
            {
                throw new NotSupportedException($"Target format '{targetFormat}' is not supported.");
            }
        }
    }
}