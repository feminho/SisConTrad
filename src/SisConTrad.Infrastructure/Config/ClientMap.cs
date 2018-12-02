using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisConTrad.Infrastructure.Config
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {

            builder.HasMany(p => p.Projects)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId);

            builder.HasMany(p => p.Messages)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId);

            builder.Property(p => p.Id)
                .UseSqlServerIdentityColumn();

            builder.Property(p => p.Email)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.WhatsApp)
                .HasColumnType("varchar(20)");

            builder.Property(p => p.IsActive)
                .HasDefaultValue(true);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
