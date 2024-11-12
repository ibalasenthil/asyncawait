using Newtonsoft.Json;

namespace apiintegration.Models
{
    public class Nation
    {
        [JsonProperty("count")]

        public int Count { get; set; }
        [JsonProperty("name")]

        public string Name { get; set; }
        [JsonProperty("country")]
    
        public List<Country> Country { get; set; }

    }
    public class Country
    {
        //public string Name { get; set; }
        [JsonProperty("country_id")]

        public string CountryId { get; set; }
        [JsonProperty("probability")]

        public double Probability { get; set; }
    }
}
