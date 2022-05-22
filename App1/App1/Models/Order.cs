using System.Collections.Generic;
using Newtonsoft.Json;

namespace App1.Models
{
    public class Order
    { 
        [JsonProperty("from_country", Required = Required.Always)]
        public string FromCountry { get; set; }

        [JsonProperty("from_zip", Required = Required.Always)]
        public long FromZip { get; set; }

        [JsonProperty("from_state", Required = Required.Always)]
        public string FromState { get; set; }

        [JsonProperty("from_city", Required = Required.Always)]
        public string FromCity { get; set; }

        [JsonProperty("from_street", Required = Required.Always)]
        public string FromStreet { get; set; }

        [JsonProperty("to_country", Required = Required.Always)]
        public string ToCountry { get; set; }

        [JsonProperty("to_zip", Required = Required.Always)]
        public long ToZip { get; set; }

        [JsonProperty("to_state", Required = Required.Always)]
        public string ToState { get; set; }

        [JsonProperty("to_city", Required = Required.Always)]
        public string ToCity { get; set; }

        [JsonProperty("to_street", Required = Required.Always)]
        public string ToStreet { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public long Amount { get; set; }

        [JsonProperty("shipping", Required = Required.Always)]
        public double Shipping { get; set; }

        [JsonProperty("nexus_addresses", Required = Required.Always)]
        public List<NexusAddress> NexusAddresses { get; set; }

        [JsonProperty("line_items", Required = Required.Always)]
         public List<LineItem> LineItems { get; set; }
        }
    }