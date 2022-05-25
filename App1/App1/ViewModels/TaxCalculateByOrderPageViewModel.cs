using System.Windows.Input;
using App1.Interfaces;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class TaxCalculateByOrderPageViewModel: ViewModelBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILoggerService _logger;
        
        public ICommand GetTaxRatesForOrderCommand { get; private set; }
        
        public TaxCalculateByOrderPageViewModel()
        {
            _taxCalculatorService = DependencyService.Get<ITaxCalculatorService>();
            _logger = DependencyService.Get<ILoggerService>();
            GetTaxRatesForOrderCommand  = new Command(async () => await GetTaxRatesForOrder(ZipCode));
        }
    }
}