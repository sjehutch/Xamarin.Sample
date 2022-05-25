using System.Collections.Generic;
using Newtonsoft.Json;

namespace App1.Models.Response
{
    public class TaxRateResponse
    {
        public NexusAddress NexusAddress { get; set; }
        public decimal StateRate { get; set; }
        public decimal CountyRate { get; set; }
        [JsonProperty("city_rate")] 
        public decimal CityRate { get; set; }
        public decimal CombinedDistrictRate { get; set; }
        [JsonProperty("combined_rate")]
        public decimal CombinedRate { get; set; }
        public bool FreightTaxable { get; set; }
        public TaxRateResponse Rate { get; set; }
        public TaxRateResponse Tax { get; set; }
    }
}