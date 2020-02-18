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
        private readonly IRepositoryUser _repositoryUser;

        public AddUserHandler(IRepositoryUser repositoryUser)
        {
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
            if (_repositoryUser.Exist(x=>x.Email == request.Email))
            {
                AddNotification("Email", "E-mail já cadastrado no sistema. ");
                return new Response(this);
            }

            Entities.User user = new Entities.User();

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;

            _repositoryUser.Adicionar(user);
    }

            



        }
    }
}
