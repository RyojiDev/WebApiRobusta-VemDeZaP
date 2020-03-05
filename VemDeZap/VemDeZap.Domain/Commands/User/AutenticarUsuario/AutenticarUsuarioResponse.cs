using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Commands.User.AutenticarUsuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public bool Autenticado { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.User user)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = user.Id,
                Name = user.FirstName,
                Autenticado = true
            };
        }
    }
}
