using System;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wrapper wrapper = null;

            using (var reader = File.OpenText("testdata/grids.json")) 
            {
                using (var jsonTextReader = new JsonTextReader(reader)) 
                {
                    var jsonSerializer = new JsonSerializer();
                    wrapper = jsonSerializer.Deserialize(jsonTextReader, typeof(Wrapper)) as Wrapper; 
                }
            }

            for (int i = 0; i < wrapper.Grids.Length; ++i)
            {
                Console.WriteLine("grids[{0}] = {1}", i, wrapper.Grids[i].Name);
            }
        }
    }
}
