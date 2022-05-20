using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface ILoginService
    {
        Task LoginAsync(string username, string password);
        Task LogoutAsync();
        Task RegisterAsync(string username, string password);
        Task ChangePasswordAsync(string oldPassword, string newPassword);
        Task ChangeUsernameAsync(string oldUsername, string newUsername);
        Task ChangeEmailAsync(string oldEmail, string newEmail);
        Task<bool> IsLoggedInAsync();
        Task<bool> IsRegisteredAsync(string username);
    }
}