using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Interfaces.Services
{
    public interface IClientService
    {
        Client GetById(int? id);
        IEnumerable<Client> GetAll();
        IEnumerable<Client> GetByExpression(Expression<Func<Client, bool>> predicate);
        Client Create(Client entity);
        void Update(Client entity);
        void Delete(int id);
    }
}
