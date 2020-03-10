using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.Extensions;
using VemDeZap.Domain.interfaces.Repositories;

namespace VemDeZap.Domain.Commands.User.AutenticarUsuario
{
    public class AutenticarUsuarioHandler : Notifiable, IRequestHandler<AutenticarUsuarioResquest, AutenticarUsuarioResponse>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryUser _repositoryUser;

        public AutenticarUsuarioHandler(IMediator mediator, IRepositoryUser repositoryUser)
        {
            _mediator = mediator;
            _repositoryUser = repositoryUser;
        }

        public async Task<AutenticarUsuarioResponse> Handle(AutenticarUsuarioResquest request, CancellationToken cancellationToken)
        {
            //Valida se o objeto request esta nulo
            if(request == null)
            {
                AddNotification("Request", "Request é obrigatorio");
                return null;
            }

            request.Senha = request.Senha.ConvertToMD5();
            Entities.User user = _repositoryUser.ObterPor(x => x.Email == request.Email && x.Password == request.Senha);


            if (user == null)
            {
                AddNotification("Usuario", "Usuario não encontrado. ");
                return new AutenticarUsuarioResponse()
                {
                    Autenticado = false
                };
            }

            //Cria Objeto de resposta

            var response = (AutenticarUsuarioResponse)user;
            return await Task.FromResult(response);
        }

    }
}
