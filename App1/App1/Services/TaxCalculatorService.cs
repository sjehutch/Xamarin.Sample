using System.Threading.Tasks;
using App1.Interfaces;
using App1.Models;

namespace App1.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        public Task<decimal> CalculateTaxForLocation(NexusAddress nexusAddress)
        {
            throw new System.NotImplementedException();
        }

        public Task<decimal> CalculateTaxForOrder(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}