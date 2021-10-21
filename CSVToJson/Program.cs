using CsvHelper;
using System;
using System.IO;
using System.Text.Json;

namespace CSVToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"C:\Day28\CopyCSVFile\Vishal2.csv";
            string pathDest = @"C:\Day28\CopyCSVFile\Vishal.json";
            using (var reader = new StreamReader(pathSource))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))

            {
                var record = csv.GetRecords<CSVData>();
                foreach (CSVData data in record)
                {
                    Console.WriteLine(data.Name);
                    Console.WriteLine(data.Mail);
                }


                JsonSerializer se = new JsonSerializer();
                using (StreamWriter wr = new StreamWriter(pathDest))
                using (JsonWriter writer = new JsonTextWriter(wr))
                {
                    se.Serialize(writer, record);
                }
            }
        }
    }
}
