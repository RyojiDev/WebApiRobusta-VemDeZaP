using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.interfaces.Repositories;

namespace VemDeZap.Domain.Commands.User.AddUser
{
    public class AddUserHandler : Notifiable, IRequestHandler<RequestAddUser, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryUser _repositoryUser;

        public AddUserHandler(IMediator mediator, IRepositoryUser repositoryUser)
        {
            _mediator = mediator;
            _repositoryUser = repositoryUser;
        }

        public async Task<Response> Handle(RequestAddUser request, CancellationToken cancellationToken)
        {

            // Validar se o request veio preenchido
            if (request == null)
            {
                AddNotification("Request", "Informe os dados do usuário.");

                return new Response(this);

            }
            // Verificar se o usuário já existe
            if (_repositoryUser.Exist(x => x.Email == request.Email))
            {
                AddNotification("Email", "E-mail já cadastrado no sistema. ");
                return new Response(this);
            }

            Entities.User user = new Entities.User(request.FirstName, request.LastName, request.Email, request.Password);
            AddNotifications(user);

            if (IsInvalid())
            {
                return new Response(this);
            }

            user = _repositoryUser.Adicionar(user);

            // Criar meu objeto de resposta
            var response = new Response(this, user);

            AddUserNotification addUserNotification = new AddUserNotification(user);

            await _mediator.Publish(addUserNotification);

            return await Task.FromResult(response);
        }





    }
}

