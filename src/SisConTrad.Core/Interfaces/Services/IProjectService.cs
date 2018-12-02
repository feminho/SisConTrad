using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Interfaces.Services
{
    public interface IProjectService
    {
        Project GetById(int id);
        IEnumerable<Project> GetAll();
        IEnumerable<Project> GetByExpression(Expression<Func<Project, bool>> predicate);
        Project Create(Project entity);
        void Update(Project entity);
        void Delete(int id);
    }
}
