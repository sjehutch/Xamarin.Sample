using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using App1.Interfaces;
using App1.Models;
using App1.Models.Request;
using App1.Models.Response;
using Newtonsoft.Json;

namespace App1.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {

        private static readonly HttpClient client = new();

        public async Task<decimal> CalculateTaxBasedOnZipCode(string zipCode)
        {
            return await GetTaxRate(zipCode);
        }

        private static async Task<decimal> GetTaxRate(string zipCode)
        {
            decimal taxRateResult = 0;
            // Normally I would have httpclient and httpresponsemessage as a dependency, but for this project I am using the static methods
            client.DefaultRequestHeaders.Add("Authorization", "Token token=" + Settings.TaxJarKey);
            var response = await client.GetAsync($"{Settings.TaxJarApiBase}rates/{zipCode}");
            if (!response.IsSuccessStatusCode) return taxRateResult;
            var content = await response.Content.ReadAsStringAsync();
            var taxRateResponse = JsonConvert.DeserializeObject<TaxRateResponse>(content);
            if (taxRateResponse is { Rate: { } }) taxRateResult = taxRateResponse.Rate.CombinedRate;
            return taxRateResult;
        }


        public async Task<TaxOrderResponse> CalculateTaxBasedOnOrder(PostOrder order)
        {
            return await GetTaxForOrder(order);
        }

        private async Task<TaxOrderResponse> GetTaxForOrder(PostOrder order)
        {
            client.DefaultRequestHeaders.Add("Authorization", "Token token=" + Settings.TaxJarKey);

            decimal taxRateResult = 0;
            var json = JsonConvert.SerializeObject(order);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var taxOrderResponse = await client.PostAsync($"{Settings.TaxJarApiBase}taxes", content);
            if (!taxOrderResponse.IsSuccessStatusCode) return null;
            var taxOrderResult = await taxOrderResponse.Content.ReadAsStringAsync();
            var taxResponseDeserializeObject = JsonConvert.DeserializeObject<TaxOrderResponse>(taxOrderResult);

            var response = new TaxOrderResponse()
            {
                OrderTotalAmount = taxResponseDeserializeObject.OrderTotalAmount
                Shipping = taxResponseDeserializeObject.Shipping,
                TaxableAmount = taxResponseDeserializeObject.TaxableAmount,
                AmountToCollect = taxResponseDeserializeObject.AmountToCollect,
                TaxRate = taxResponseDeserializeObject.TaxRate,
                HasNexus = taxResponseDeserializeObject.HasNexus,
                FreightTaxable = taxResponseDeserializeObject.FreightTaxable,
                TaxSource = taxResponseDeserializeObject.TaxSource,
                ExemptionType = taxResponseDeserializeObject.ExemptionType,
            };

            return response;
        }
    }
}
    