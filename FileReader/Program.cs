using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> results = new List<string[]>();

            using (var reader = new StreamReader(@"C:\Users\andre\OneDrive\Desktop\example.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');

                    results.Add(values);
                }
            }

            Console.WriteLine(JsonConvert.SerializeObject(results));
        }
    }
}
