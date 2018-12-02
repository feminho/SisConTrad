using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisConTrad.Infrastructure.Config
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.HasMany(t => t.Translations)
                    .WithOne(p => p.Project)
                    .HasForeignKey(p => p.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.Id)
                    .UseSqlServerIdentityColumn();

            builder.Property(p => p.ProjectName)
                    .HasColumnType("varchar(255)")
                    .IsRequired();

            builder.Property(p => p.ProjectCode)
                    .HasColumnType("varchar(10)");

            builder.Property(p => p.PaymentMode)
                    .HasColumnType("varchar(20)");
        }
    }
}
