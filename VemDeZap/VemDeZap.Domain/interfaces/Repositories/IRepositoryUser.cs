using System;
using VemDeZap.Domain.Entities;
using VemDeZap.Domain.interfaces.Repositories.Base;

namespace VemDeZap.Domain.interfaces.Repositories
{
    public interface IRepositoryUser : IRepositoryBase<User,Guid>
    {

    }
}
