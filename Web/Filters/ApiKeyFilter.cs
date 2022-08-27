using CRM.Application.Common.Interfaces;
using CRM.Web.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Web.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeApiKeyFilter : Attribute, IAsyncActionFilter
    {
        private readonly bool _isApiKeyRequired;

        public AuthorizeApiKeyFilter(bool isApiKeyRequired = true)
        {
            _isApiKeyRequired = isApiKeyRequired;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var actionFilter = context.ActionDescriptor.FilterDescriptors.LastOrDefault(f => f.Filter.GetType() == typeof(AuthorizeApiKeyFilter))
                ?.Filter;

            if (actionFilter != null && !((AuthorizeApiKeyFilter)actionFilter)._isApiKeyRequired)
            {
                await next();
                return;
            }

            if (_isApiKeyRequired)
            {
                var httpContextAccesor = context.HttpContext.RequestServices.GetRequiredService<IHttpContextAccessor>();
                var apiAuthService = context.HttpContext.RequestServices.GetRequiredService<IApiAuthService>();

                var httpContext = httpContextAccesor.HttpContext;

                if (!httpContext.Request.Headers.TryGetValue(ApiConstants.ApiKeyHeaderName, out var key))
                {
                    throw new Exception("No Api Key provided");
                }

                if (!await apiAuthService.ApiKeyExists(key))
                {
                    throw new Exception("Missing or incorrect Api Key");
                }
            }

            await next();
        }
    }
}
