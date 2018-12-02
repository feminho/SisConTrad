using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisConTrad.Infrastructure.Config
{
    public class TranslationMap : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {

           builder.Property(p => p.Id)
                .UseSqlServerIdentityColumn();

           builder.Property(p => p.FileToBeTranslate)
                .IsRequired();

           builder.Property(p => p.ProjectType)
                .HasColumnType("varchar(20)");
        }
    }
}
