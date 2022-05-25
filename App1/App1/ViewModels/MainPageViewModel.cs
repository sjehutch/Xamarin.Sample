using System.Threading.Tasks;
using System.Windows.Input;
using App1.Interfaces;
using App1.Pages;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ILoggerService _logger;
        
        public ICommand CalculateByRateCommand { get; set; }

        public MainPageViewModel()
        {
            _logger = DependencyService.Get<ILoggerService>();
            CalculateByRateCommand = new Command(async () => await CalculateByRate());
        }

        private async Task CalculateByRate()
        {
            // Generally I would use a navigation service to navigate to the next page
            await _logger.Log("CalculateByRateCommand");
            await App.Current.MainPage.Navigation.PushAsync(new TaxCalculateByZipCodePage(),true);
        }
    }
}