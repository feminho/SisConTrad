using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(int? id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByExpression(Expression<Func<T,bool>> predicate);
        T Create(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}
