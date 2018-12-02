using Microsoft.EntityFrameworkCore;
using SisConTrad.Core.Model;
using SisConTrad.Infrastructure.Config;
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

            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new ProjectMap());
            modelBuilder.ApplyConfiguration(new TranslationMap());
            modelBuilder.ApplyConfiguration(new MessageMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
