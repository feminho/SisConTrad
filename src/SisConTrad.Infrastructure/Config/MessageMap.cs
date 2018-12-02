using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisConTrad.Infrastructure.Config
{
    public class MessageMap : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(p => p.Id)
                .UseSqlServerIdentityColumn();

        }
    }
}
