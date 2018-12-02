using SisConTrad.Core.Interfaces.Repository;
using SisConTrad.Core.Model;
using SisConTrad.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisConTrad.Infrastructure.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(SisConTradContex dbContext) : base(dbContext)
        {
        }
    }
}
