using System.Threading.Tasks;
using System.Windows.Input;
using App1.Interfaces;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class TaxCalculateByZipCodePageViewModel : ViewModelBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILoggerService _logger;
        
        public ICommand GetTaxRatesCommand { get; private set; }
        
        // Generally I would use MVVM helpers or fody to bind these properties, but for this example I'm just going to use the properties directly
       private bool _taxIsVisible;
        public bool TaxIsVisible
        {
            get => _taxIsVisible;
            set
            {
                _taxIsVisible = value;
                OnPropertyChanged();
            }
        }
        
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        
        private string _zipCode;
        public string ZipCode
        {
            get => _zipCode;
            set
            {
                _zipCode = value;
                OnPropertyChanged();
            }
        }
        
        private decimal _taxRate;
        public decimal TaxRate
        {
            get => _taxRate;
            set
            {
                _taxRate = value;
                OnPropertyChanged();
            }
        }
       
        
        public TaxCalculateByZipCodePageViewModel() 
        {
            _taxCalculatorService = DependencyService.Get<ITaxCalculatorService>();
            _logger = DependencyService.Get<ILoggerService>();
            GetTaxRatesCommand  = new Command(async () => await GetTaxRates(ZipCode));
        }
        
        private async Task GetTaxRates(string zipCode)
        {
            await _logger.Log("Getting tax rates for zip code: " + zipCode);
            
            if (!string.IsNullOrEmpty(zipCode))
            {
                zipCode = ZipCode;
            }
            IsBusy = true;
            var taxRate = await _taxCalculatorService.CalculateTaxBasedOnZipCode(zipCode);
            TaxRate = taxRate;
            IsBusy = false;
            TaxIsVisible = true;
        }
    }
}