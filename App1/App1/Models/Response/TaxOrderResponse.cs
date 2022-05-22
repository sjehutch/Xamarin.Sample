namespace App1.Models.Response
{
    public class TaxOrderResponse
    {
        public decimal OrderTotalAmount { get; set; }
        public decimal Shipping { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal AmountToCollect { get; set; }
        public decimal TaxRate { get; set; }
        public bool HasNexus { get; set; }
        public bool FreightTaxable { get; set; }
        public string TaxSource { get; set; }
        public string ExemptionType { get; set; }
        public Order Order { get; set; }
    }
}