using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Core.Interfaces.Services;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SisConTrad.Core.Services
{
    public class ClientService : IClientService
    {
       private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Create(Client entity)
        {
            return _clientRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public IEnumerable<Client> GetByExpression(Expression<Func<Client, bool>> predicate)
        {
            return _clientRepository.GetByExpression(predicate);
        }

        public Client GetById(int? id)
        {
            return _clientRepository.GetById(id);
        }

        public void Update(Client entity)
        {
            _clientRepository.Update(entity);
        }
    }
}
