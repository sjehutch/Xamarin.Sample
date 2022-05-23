using System.Threading.Tasks;
using System.Windows.Input;
using App1.Interfaces;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class TaxRatesForLocationViewModel : ViewModelBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILoggerService _logger;
        
        public ICommand GetTaxRatesCommand { get; private set; }
        
        
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
       
        
        public TaxRatesForLocationViewModel() 
        {
            _taxCalculatorService = DependencyService.Get<ITaxCalculatorService>();
            GetTaxRatesCommand  = new Command(async () => await GetTaxRates(ZipCode));
        }
        
        private async Task GetTaxRates(string zipCode)
        {
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