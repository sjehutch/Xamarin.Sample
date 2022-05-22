using System;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface ILoggerService
    {
        Task Log(string message);
        Task Log(Exception ex);
        Task LogGoogleAnalytics(string message);
        Task LogAppCenter(string message);
    }
}