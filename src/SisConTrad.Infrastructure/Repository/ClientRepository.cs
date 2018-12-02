using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Infrastructure.Data;

namespace SisConTrad.Infrastructure.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(SisConTradContex dbContext) : base(dbContext)
        {
        }
    }
}
