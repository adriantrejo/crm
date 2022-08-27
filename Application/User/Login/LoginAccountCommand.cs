using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using CRM.Application.Common.Interfaces;
using MediatR;

namespace CRM.Application.User.Login
{

    public class LoginAccountCommand : IRequest<LoginAccountResponseDTO>
    {
        public LoginAccountRequestDTO Account { get; set; }
    }

    public class LoginCommandHandler : IRequestHandler<LoginAccountCommand, LoginAccountResponseDTO>
    {
        private readonly IIdentityService _identityService;

        public LoginCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<LoginAccountResponseDTO> Handle(LoginAccountCommand request, CancellationToken cancellationToken)
        {
            return await _identityService.LoginAsync(request.Account);
        }
    }
}
