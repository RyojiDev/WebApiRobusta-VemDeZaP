using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entities;
using VemDeZap.Domain.interfaces.Repositories;
using VemDeZap.Infra.Repositories.Base;

namespace VemDeZap.Infra.Repositories
{
    public class RepositoryGroup : RepositoryBase<Group,Guid>, IRepositoryGroup
    {
        private readonly VemDeZapContext _context;

        public RepositoryGroup(VemDeZapContext context) : base(context)
        {
            _context = context;
        }
    }
}
