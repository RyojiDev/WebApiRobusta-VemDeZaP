using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VemDeZap.Api.Security
{
    public class SigningConfiguration
    {
        private const string SECRET_KEY = "c1f51f42-5727-4d15-b787-c6bbbb645024";


        public SigningCredentials SigningCredentials { get; }
        private readonly SymmetricSecurityKey _signingkey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRET_KEY));



        public SigningConfiguration()
        {
            SigningCredentials = new SigningCredentials(_signingkey, SecurityAlgorithms.HmacSha256);
        }

    }
}
