using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Commands.Group.AlterGroup
{
    public class AlterGroupRequest : IRequest<Response>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EnumNiche Niche { get; set; }
        public Guid? IdUser { get; set; }
    }
}
