using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Core.Interfaces.Services;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Services
{
    public class MessageService : IMessageService
    {
       private readonly IMessageRepository _MessageRepository;

        public MessageService(IMessageRepository MessageRepository)
        {
            _MessageRepository = MessageRepository;
        }

        public Message Create(Message entity)
        {
            return _MessageRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _MessageRepository.Delete(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return _MessageRepository.GetAll();
        }

        public IEnumerable<Message> GetByExpression(Expression<Func<Message, bool>> predicate)
        {
            return _MessageRepository.GetByExpression(predicate);
        }

        public Message GetById(int id)
        {
            return _MessageRepository.GetById(id);
        }

        public void Update(Message entity)
        {
            _MessageRepository.Update(entity);
        }
    }
}
