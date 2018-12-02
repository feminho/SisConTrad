using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Interfaces.Services
{
    public interface ITranslationService
    {
        Translation GetById(int id);
        IEnumerable<Translation> GetAll();
        IEnumerable<Translation> GetByExpression(Expression<Func<Translation, bool>> predicate);
        Translation Create(Translation entity);
        void Update(Translation entity);
        void Delete(int id);
    }
}
