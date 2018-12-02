using Microsoft.EntityFrameworkCore;
using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SisConTradContex _dbContext;

        public Repository(SisConTradContex dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T Create(T entity)
        {
            T et =_dbContext.Add(entity).Entity;
            _dbContext.SaveChanges();
            return et;

        }
        public virtual void Delete(int id) => _dbContext.Remove(GetById(id));

        public IEnumerable<T> GetAll() => _dbContext.Set<T>();

        public T GetById(int? id) => _dbContext.Set<T>().Find(id);

        public virtual void Update(T entity) => _dbContext.Entry(entity).State = EntityState.Modified;

        public IEnumerable<T> GetByExpression(Expression<Func<T, bool>> predicate) => _dbContext.Set<T>().Where(predicate).AsEnumerable();
     
    }
}
