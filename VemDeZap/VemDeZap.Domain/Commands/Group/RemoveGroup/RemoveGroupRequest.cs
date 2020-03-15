using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Commands.Group.RemoveGroup
{
    public class RemoveGroupRequest : IRequest<Response>
    {
        public Guid Id { get; set; }
        public RemoveGroupRequest(Guid id)
        {
            Id = id;
        }
    }
}
