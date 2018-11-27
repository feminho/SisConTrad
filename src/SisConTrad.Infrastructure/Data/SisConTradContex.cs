using Microsoft.EntityFrameworkCore;
using SisConTrad.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisConTrad.Infrastructure.Data
{
    public class SisConTradContex : DbContext
    {
        public SisConTradContex(DbContextOptions<SisConTradContex> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Message> Messages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<Translation>().ToTable("Translations");
            modelBuilder.Entity<Message>().ToTable("Messages");

            #region Client Config

            modelBuilder.Entity<Client>().Property(p => p.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Client>().Property(p => p.Email)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Client>().Property(p => p.WhatsApp)
                .HasColumnType("varchar(20)");

            modelBuilder.Entity<Client>().Property(p => p.Name)
                .HasColumnType("varchar(255)")
                .IsRequired();

            #endregion

            #region Project Config

            modelBuilder.Entity<Project>().Property(p => p.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Project>().Property(p => p.ProjectName)
                .HasColumnType("varchar(255)")
                .IsRequired();

            modelBuilder.Entity<Project>().Property(p => p.ProjectCode)
                .HasColumnType("varchar(10)");

            modelBuilder.Entity<Project>().Property(p => p.PaymentMode)
                .HasColumnType("varchar(20)");

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Client);
                
            #endregion

            #region Translation Config

            modelBuilder.Entity<Translation>().Property(p => p.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Translation>().Property(p => p.FileToBeTranslate)
                .IsRequired();

            modelBuilder.Entity<Translation>().Property(p => p.ProjectType)
                .HasColumnType("varchar(20)");

            #endregion

            #region Message Config

            modelBuilder.Entity<Message>().Property(p => p.Id)
                .UseSqlServerIdentityColumn();

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
