using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Commands.Group.AddGroup
{
    public class AdicionarGrupoRequest : IRequest<Response>
    {
        public string Name { get; set; }
        public EnumNiche Niche { get; set; }
        public Guid? IdUser { get; set; }

    }
}
