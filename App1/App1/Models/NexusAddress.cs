using Newtonsoft.Json;

namespace App1.Models
{
    public class NexusAddress
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("country", Required = Required.Always)]
        public string Country { get; set; }

        [JsonProperty("zip", Required = Required.Always)]
        public long Zip { get; set; }

        [JsonProperty("state", Required = Required.Always)]
        public string State { get; set; }

        [JsonProperty("city", Required = Required.Always)]
        public string City { get; set; }

        [JsonProperty("street", Required = Required.Always)]
        public string Street { get; set; }
    }
}