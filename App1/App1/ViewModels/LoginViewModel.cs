using System.Threading.Tasks;
using App1.Interfaces;

namespace App1.ViewModels
{
    public class LoginViewModel
    {
        ILoginService _loginService;
        IloggerService _loggerService;
        
        public LoginViewModel(ILoginService loginService , IloggerService loggerService)
      
        {
            _loginService = loginService;
            _loggerService = loggerService;
        }
        
        public async Task Login(string username, string password)
        {
            await _loginService.LoginAsync(username, password);
        }
        
        
    }
    
}