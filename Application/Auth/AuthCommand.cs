using CRM.Application.Common;
using CRM.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Application.Auth
{
    public class AuthCommand : IRequest<(Result, string)>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AuthCommandHandler : IRequestHandler<AuthCommand, (Result, string)>
    {
        private readonly IApiAuthService _apiAuthService;

        public AuthCommandHandler(IApiAuthService apiAuthService)
        {
            _apiAuthService = apiAuthService;
        }

        public async Task<(Result, string)> Handle(AuthCommand request, CancellationToken cancellationToken)
        {
            return await _apiAuthService.LoginAsync(request.Username, request.Password);
        }
    }
}
