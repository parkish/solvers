using Newtonsoft.Json;

namespace ConsoleApplication
{
    public class Wrapper
    {
        [JsonProperty("grids")]
        public Grid[] Grids { get; set; }
    }

    [JsonObject]
    public class Grid 
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("rows")]
        public string[] Rows { get; set; }
    }
}