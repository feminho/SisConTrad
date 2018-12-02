using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Core.Interfaces.Services;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Services
{
    public class ProjectService : IProjectService
    {
       private readonly IProjectRepository _ProjectRepository;

        public ProjectService(IProjectRepository ProjectRepository)
        {
            _ProjectRepository = ProjectRepository;
        }

        public Project Create(Project entity)
        {
            return _ProjectRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _ProjectRepository.Delete(id);
        }

        public IEnumerable<Project> GetAll()
        {
            return _ProjectRepository.GetAll();
        }

        public IEnumerable<Project> GetByExpression(Expression<Func<Project, bool>> predicate)
        {
            return _ProjectRepository.GetByExpression(predicate);
        }

        public Project GetById(int id)
        {
            return _ProjectRepository.GetById(id);
        }

        public void Update(Project entity)
        {
            _ProjectRepository.Update(entity);
        }
    }
}
