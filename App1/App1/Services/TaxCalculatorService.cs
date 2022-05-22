using System.Net.Http;
using System.Threading.Tasks;
using App1.Interfaces;
using App1.Models;
using App1.Models.Response;
using Newtonsoft.Json;

namespace App1.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        public async Task<decimal> CalculateTaxBasedOnZipCode(string zipCode)
        {
            return await GetTaxRate(zipCode);
        }

        private async Task<decimal> GetTaxRate(string zipCode)
        {
            decimal taxRateResult = 0;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("ApiKey", Settings.TaxJarKey);
            var response = await client.GetAsync($"{Settings.TaxJarApiBase}rates/{zipCode}");
            if (!response.IsSuccessStatusCode) return taxRateResult;
            var content = await response.Content.ReadAsStringAsync();
            var taxRateResponse = JsonConvert.DeserializeObject<TaxRateResponse>(content);
            if (taxRateResponse != null) taxRateResult = taxRateResponse.StateRate;

            return taxRateResult;
        }
        

        public async Task<decimal> CalculateTaxBasedOnAddress(NexusAddress address)
        {
            throw new System.NotImplementedException();
        }
    }
}