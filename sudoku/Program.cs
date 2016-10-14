using System;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    public class Data 
    {
        public string Version { get; set;}
    } 

    public class Program
    {
        public static void Main(string[] args)
        {
            Data data = null;

            using (var reader = File.OpenText("project.json")) 
            {
                using (var jsonTextReader = new JsonTextReader(reader)) 
                {
                    var jsonSerializer = new JsonSerializer();
                    data = jsonSerializer.Deserialize(jsonTextReader, typeof(Data)) as Data; 
                }
            }
            
            Console.WriteLine("Loaded version = {0}", data.Version);
        }
    }
}
