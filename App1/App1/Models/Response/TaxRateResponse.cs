namespace App1.Models.Response
{
    public class TaxRateResponse
    {
        public NexusAddress NexusAddress { get; set; }
        public decimal StateRate { get; set; }
        public decimal CountyRate { get; set; }
        public decimal CityRate { get; set; }
        public decimal CombinedDistrictRate { get; set; }
        public decimal CombinedRate { get; set; }
        public bool FreightTaxable { get; set; }
    }
}