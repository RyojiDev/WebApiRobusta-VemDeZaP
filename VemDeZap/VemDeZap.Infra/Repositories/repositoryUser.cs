using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using VemDeZap.Domain.Entities;
using VemDeZap.Domain.interfaces.Repositories;

namespace VemDeZap.Infra.Repositories
{
    public class RepositoryUser : IRepositoryUser
    {
        public User Adicionar(User entidade)
        {
            throw new NotImplementedException();
        }

        public void AdicionarLista(IEnumerable<User> entidades)
        {
            throw new NotImplementedException();
        }

        public User Editar(User entidade)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Func<User, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> Listar(params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> ListarEOrdenadosPor<TKey>(Expression<Func<User, bool>> where, Expression<Func<User, TKey>> ordem, bool ascendente = true, params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> ListarOrdenadosPor<TKey>(Expression<Func<User, TKey>> ordem, bool ascendente = true, params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> ListarPor<TKey>(Expression<Func<User, bool>> where, params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public User ObterPor(Func<User, bool> where, params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public User ObterPorId(Guid id, params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Remover(User entidade)
        {
            throw new NotImplementedException();
        }

        public void Remover(IEnumerable<User> entidades)
        {
            throw new NotImplementedException();
        }
    }
}
