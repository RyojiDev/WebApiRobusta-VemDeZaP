using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Commands.User.AutenticarUsuario
{
    public class AutenticarUsuarioResquest : IRequest<AutenticarUsuarioResponse>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
