using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.interfaces.Repositories.Base;

namespace VemDeZap.Domain.interfaces.Repositories
{
    public interface IRepositoryGroup : IRepositoryBase<IRepositoryGroup, Guid>
    {
    }
}
