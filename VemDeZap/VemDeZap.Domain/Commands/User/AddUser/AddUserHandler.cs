using MediatR;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.interfaces.Repositories;
using VemDeZap.Domain.Resources;

namespace VemDeZap.Domain.Commands.User.AddUser
{
    public class AddUserHandler : Notifiable, IRequestHandler<RequestAddUser, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryUser _repositoryUsuario;

        public AddUserHandler(IMediator mediator, IRepositoryUser repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<Response> Handle(RequestAddUser request, CancellationToken cancellationToken)
        {
            //Validar se o requeste veio preenchido
            if (request == null)
            {
                AddNotification("Resquest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("Usuário"));
                return new Response(this);
            }

            //Verificar se o usuário já existe
            if (_repositoryUsuario.Existe(x => x.Email == request.Email))
            {
                AddNotification("Email", MSG.ESTE_X0_JA_EXISTE.ToFormat("E-mail"));
                return new Response(this);
            }

            Entities.User user = new Entities.User(request.FirstName, request.LastName, request.Email, request.Password);
            AddNotifications(user);

            if (IsInvalid())
            {
                return new Response(this);
            }

            user = _repositoryUsuario.Adicionar(user);

            //Criar meu objeto de resposta
            var response = new Response(this, user);

            AddUserNotification adicionarUsuarioNotification = new AddUserNotification(user);

            await _mediator.Publish(adicionarUsuarioNotification);

            return await Task.FromResult(response);



        }
    }

}

