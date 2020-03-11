using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Api.Security;
using VemDeZap.Domain.Commands.Group.ListGroup;
using VemDeZap.Domain.Commands.User.AddUser;
using VemDeZap.Domain.Commands.Group;
using VemDeZap.Domain.Commands.User.AutenticarUsuario;
using VemDeZap.Infra.Repositories.Transactions;

namespace VemDeZap.Api.Controllers
{
    //[Route("api/[controller]")]
    //[Route("api/Usuario")]
    //[ApiController]
    public class GroupController : Base.ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GroupController(IHttpContextAccessor httpContextAccessor,IMediator mediator, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;

        }

        [Authorize]
        [HttpGet]
        [Route("api/Grupo/Listar")]
        public async Task<IActionResult> ListarGrupo()
        {
            try
            {
                var request = new ListGroupRequest();
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("api/Grupo/Adicionar")]

        public async Task<IActionResult> AdicionarGrupo([FromBody]AdicionarGrupoRequest request)
        {

        }



    }

}

