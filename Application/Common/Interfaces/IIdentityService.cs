using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using CRM.Application.User.Login;

namespace CRM.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<LoginAccountResponseDTO> LoginAsync(LoginAccountRequestDTO request);
    }
}
