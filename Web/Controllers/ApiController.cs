
using CRM.Web.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.Web.Controllers
{
    [ApiController]
    [AuthorizeApiKeyFilter]
    //[ApiVersion(Api.CurrentVersion)]
    public abstract class ApiController : ControllerBase
    {       
        //Patron mediador
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
