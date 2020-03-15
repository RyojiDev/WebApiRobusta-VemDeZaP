using MediatR;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.interfaces.Repositories;
using VemDeZap.Domain.Resources;

namespace VemDeZap.Domain.Commands.Group.ListGroup
{
    public class ListGroupHandler : Notifiable, IRequestHandler<ListGroupRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryGroup _repositoryGroup;

        public ListGroupHandler(IMediator mediator, IRepositoryGroup repositoryGrupo)
        {
            _mediator = mediator;
            _repositoryGroup = repositoryGrupo;
        }

        public async Task<Response> Handle(ListGroupRequest request, CancellationToken cancelationToken)
        {
            // Valida se o objeto request esta nulo

            if(request == null)
            {
                AddNotification("Request", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("Request"));
                return new Response(this);
            }

            var GroupCollection = _repositoryGroup.Listar().ToList();

            // Cria objeto de responsa
            var response = new Response(this, GroupCollection);

            // Retorna o resultado
            return await Task.FromResult(response);
        }
    }
}
