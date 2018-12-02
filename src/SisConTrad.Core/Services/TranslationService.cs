using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Core.Interfaces.Services;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Services
{
    public class TranslationService : ITranslationService
    {
       private readonly ITranslationRepository _TranslationRepository;

        public TranslationService(ITranslationRepository TranslationRepository)
        {
            _TranslationRepository = TranslationRepository;
        }

        public Translation Create(Translation entity)
        {
            return _TranslationRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _TranslationRepository.Delete(id);
        }

        public IEnumerable<Translation> GetAll()
        {
            return _TranslationRepository.GetAll();
        }

        public IEnumerable<Translation> GetByExpression(Expression<Func<Translation, bool>> predicate)
        {
            return _TranslationRepository.GetByExpression(predicate);
        }

        public Translation GetById(int id)
        {
            return _TranslationRepository.GetById(id);
        }

        public void Update(Translation entity)
        {
            _TranslationRepository.Update(entity);
        }
    }
}
