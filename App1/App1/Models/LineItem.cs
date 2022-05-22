using Newtonsoft.Json;

namespace App1.Models
{
    public class LineItem
    {
        [JsonProperty("id", Required = Required.Always)]
        public long Id { get; set; }

        [JsonProperty("quantity", Required = Required.Always)]
        public long Quantity { get; set; }

        [JsonProperty("product_tax_code", Required = Required.Always)]
        public long ProductTaxCode { get; set; }

        [JsonProperty("unit_price", Required = Required.Always)]
        public long UnitPrice { get; set; }

        [JsonProperty("discount", Required = Required.Always)]
        public long Discount { get; set; }
    }
}