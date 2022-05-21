using System.Threading.Tasks;
using System.Windows.Input;
using App1.Interfaces;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        private readonly ILoginService _loginService;
        IloggerService _loggerService;

        public ICommand Login { get; set; }
        
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }
        
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        
        public LoginViewModel()
        {
            _loginService = DependencyService.Get<ILoginService>();
            _loggerService = DependencyService.Get<IloggerService>();
            Login = new Command(async () => await LoginAsync(Username, Password));
        }
        
        private async Task LoginAsync(string username, string password)
        {
            await _loginService.LoginAsync(Username, Password);
        }
        
    }
    
}