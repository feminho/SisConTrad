using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Interfaces.Services
{
    public interface IMessageService
    {
        Message GetById(int id);
        IEnumerable<Message> GetAll();
        IEnumerable<Message> GetByExpression(Expression<Func<Message, bool>> predicate);
        Message Create(Message entity);
        void Update(Message entity);
        void Delete(int id);
    }
}
