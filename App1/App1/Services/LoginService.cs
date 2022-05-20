using System.Threading.Tasks;
using App1.Interfaces;

namespace App1.Services
{
    public class LoginService : ILoginService
    {
        public Task LoginAsync(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task RegisterAsync(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task ChangePasswordAsync(string oldPassword, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        public Task ChangeUsernameAsync(string oldUsername, string newUsername)
        {
            throw new System.NotImplementedException();
        }

        public Task ChangeEmailAsync(string oldEmail, string newEmail)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsLoggedInAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsRegisteredAsync(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}