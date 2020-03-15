using MediatR;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.interfaces.Repositories;
using VemDeZap.Domain.Resources;

namespace VemDeZap.Domain.Commands.Group.AlterGroup
{
    class AlterGroupHandler : Notifiable, IRequestHandler<AlterGroupRequest, Response>
    {

        private readonly IMediator _mediator;
        private readonly IRepositoryGroup _repositoryGroup;
        private readonly IRepositoryUser _repositoryUser;

        public AlterGroupHandler(IMediator mediator, IRepositoryGroup repositoryGrupo, IRepositoryUser repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryGroup = repositoryGrupo;
            _repositoryUser = repositoryUsuario;
        }

        public async Task<Response> Handle(AlterGroupRequest request, CancellationToken cancellationToken)
        {
            //Validar se o requeste veio preenchido
            if (request == null)
            {
                AddNotification("Resquest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("Grupo"));
                return new Response(this);
            }

            var usuario = _repositoryUser.ObterPorId(request.IdUser.Value);


            if (usuario == null)
            {
                AddNotification("Usuario", MSG.X0_NAO_INFORMADO.ToFormat("Usuário"));
                return new Response(this);
            }


            Entities.Group grupo = _repositoryGroup.ObterPorId(request.Id);

            grupo.AlterGroup(request.Name, request.Niche);


            if (grupo == null)
            {
                AddNotification("Grupo", MSG.X0_NAO_INFORMADO.ToFormat("Grupo"));
                return new Response(this);
            }

            grupo = _repositoryGroup.Editar(grupo);

            var result = new { Id = grupo.Id, Nome = grupo.Name, Nicho = grupo.Niche };

            //Criar meu objeto de resposta
            var response = new Response(this, result);

            return await Task.FromResult(response);
        }
    }
}



