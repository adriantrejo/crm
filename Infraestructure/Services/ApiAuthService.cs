using CRM.Application.Common;
using CRM.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.Services
{
    public class ApiAuthService : IApiAuthService
    {
        //private readonly ICommonDbContext _commonDbContext;
        //public ApiAuthService(ICommonDbContext commonDbContext)
        //{
        //    _commonDbContext = commonDbContext;
        //}

        public ApiAuthService(){}

        public async Task<(Result, string)> LoginAsync(string username, string password)
        {
            //var apiUser = await _commonDbContext.ApiUsers.SingleOrDefaultAsync(s => s.Username == username && s.Active == true);
            //
            //if (apiUser != null && HashGenerator.CheckMatch(apiUser.Password, password))
            //{
            //    return (Result.Success(), apiUser.ApiKey);
            //}
            //
            //return (Result.Failure(new[] { "Incorrect API login" }), "");

            return (Result.Success(), "");
        }

        public async Task<bool> ApiKeyExists(string apiKey)
        {
            //var apiUser = await _commonDbContext.ApiUsers.FirstOrDefaultAsync(s => s.ApiKey == apiKey && s.Active == true);
            //if (apiUser != null)
            //{
            //    return true;
            //}
            //
            //return false;

            return true;
        }
    }
}
