using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VemDeZap.Domain.Commands.User.AddUser;

namespace VemDeZap.Api.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        [AllowAnonymous]
        [HttpPost]
        [Route("Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody]RequestAddUser request)
        {
            try
            {
                var response = await _mediator Send(request, CancellationToken.None);
                return await ResponseAsync(response);
            }catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
