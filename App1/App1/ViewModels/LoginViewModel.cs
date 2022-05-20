using System.Threading.Tasks;
using App1.Interfaces;

namespace App1.ViewModels
{
    public class LoginViewModel
    {
        ILoginService _loginService;
        
        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;
        }
        
        public async Task Login(string username, string password)
        {
            await _loginService.LoginAsync(username, password);
        }
    }
    
}