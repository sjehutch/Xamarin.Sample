using System;
using System.Threading.Tasks;
using App1.Interfaces;

namespace App1.Services
{
    public class LoggerService : IloggerService
    {
        public Task Log(string message)
        {
            throw new NotImplementedException();
        }

        public Task Log(Exception ex)
        {
            throw new NotImplementedException();
        }

        public Task LogGoogleAnalytics(string message)
        {
            throw new NotImplementedException();
        }

        public Task LogAppCenter(string message)
        {
            throw new NotImplementedException();
        }
    }
}