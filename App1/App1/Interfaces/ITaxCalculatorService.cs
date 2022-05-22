using System.Threading.Tasks;
using App1.Models;

namespace App1.Interfaces
{
    public interface ITaxCalculatorService
    {
        // Calculate the tax for a given price
        Task <decimal> CalculateTaxForLocation(NexusAddress nexusAddress);
        // Calculate the tax for a given state
        Task <decimal> CalculateTaxForOrder(Order order);
    }
}