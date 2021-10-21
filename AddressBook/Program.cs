using CsvHelper;
using System;
using System.IO;

namespace CSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Day28\CopyCSVFile\Vishal2.csv";
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                var record = csv.GetRecords<CSVData>();
                foreach (CSVData data in record)
                {
                    Console.WriteLine(data.Name);
                    Console.WriteLine(data.Mail);
                    Console.WriteLine(data.Contact);
                    Console.WriteLine(data.City);
                    Console.WriteLine(data.Compony);
                }
            }

        }
    }
}
