using CsvHelper;
using System;
using System.IO;

namespace CopyCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"C:\Day28\CopyCSVFile\Vishal2.csv";
            string pathDest = @"C:\Day28\CopyCSVFile\Vishal.csv";
            using (var reader = new StreamReader(pathSource))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))

            {
                var record = csv.GetRecords<CSVData>();
                foreach (CSVData data in record)
                {
                    Console.WriteLine(data.Name);
                    Console.WriteLine(data.Mail);
                }


                using (var writer = new StreamWriter(pathDest))
                using (var csv2 = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(record);
                }
            }

        }
    }
}
