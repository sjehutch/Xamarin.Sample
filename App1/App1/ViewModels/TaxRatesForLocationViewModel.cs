using App1.Interfaces;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class TaxRatesForLocationViewModel : ViewModelBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILoggerService _logger;
        
        public TaxRatesForLocationViewModel( ITaxCalculatorService taxCalculatorService, ILoggerService logger) 
        {
            _taxCalculatorService = taxCalculatorService;
            _logger = logger;
        }
    }
    
}