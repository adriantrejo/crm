using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using CRM.Web.Controllers;
using CRM.Application.Common;
using CRM.Application.User.Login;

namespace CRM.Web.Controllers
{
    [Authorize]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class AccountController : ApiController
    {
        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<ActionResult<Result>> Login([FromBody] LoginAccountCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
