using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Common.Interfaces
{
    public interface IApiAuthService
    {
        Task<(Result, string)> LoginAsync(string username, string password);
        Task<bool> ApiKeyExists(string apiKey);
    }
}
