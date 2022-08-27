//using Microsoft.AspNetCore.Authentication.JwtBearer;
using CRM.Application.Common.Interfaces;
using CRM.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
//using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;


namespace CRM.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebUiInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IApiAuthService, ApiAuthService>();

            //services.AddScoped<IServerService, HttpServerService>();

            // services.AddAuthentication(x =>
            // {
            //     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //     x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //
            // })
            //.AddJwtBearer(x =>
            //{
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ApiJWTConstants.Key)),
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //        RequireExpirationTime = true,
            //        ValidateLifetime = true,
            //        ClockSkew = TimeSpan.Zero
            //    };
            //});
            return services;
        }

       

       
    }
}
