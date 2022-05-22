using System.Threading.Tasks;
using App1.Models;
using App1.Models.Response;

namespace App1.Interfaces
{
    public interface ITaxCalculatorService
    {
        Task<decimal> CalculateTaxBasedOnZipCode(string zipCode);
        
        Task<decimal> CalculateTaxBasedOnAddress(NexusAddress address);
    }
}