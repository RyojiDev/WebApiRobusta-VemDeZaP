using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entities;
using VemDeZap.Domain.interfaces.Repositories;
using VemDeZap.Infra.Repositories.Base;

namespace VemDeZap.Infra.Repositories
{
    public class RepositoryUser : RepositoryBase<User,Guid>, IRepositoryUser
    {
        private readonly VemDeZapContext _context;
        public RepositoryUser(VemDeZapContext context): base(context)
        {
            _context = context;
        }
    }
}
