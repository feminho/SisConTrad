﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SisConTrad.Infrastructure.Data;

namespace SisConTrad.Infrastructure.Migrations
{
    [DbContext(typeof(SisConTradContex))]
    [Migration("20181120105825_CreateMainTables")]
    partial class CreateMainTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SisConTrad.Core.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("WhatsApp");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SisConTrad.Core.Model.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("MessageText")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SisConTrad.Core.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<decimal>("Discount");

                    b.Property<string>("Notes");

                    b.Property<string>("PaymentMode");

                    b.Property<string>("ProjectCode");

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.Property<string>("Receipt");

                    b.Property<decimal>("TotalTranslationsValue");

                    b.Property<decimal>("TotalValue");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SisConTrad.Core.Model.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileToBeTranslate")
                        .IsRequired();

                    b.Property<bool>("IsUrgentTranslations");

                    b.Property<int>("ProjectId");

                    b.Property<string>("ProjectType")
                        .IsRequired();

                    b.Property<int>("Step");

                    b.Property<string>("TranslatedFile");

                    b.Property<decimal>("TranslationValue");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("SisConTrad.Core.Model.Message", b =>
                {
                    b.HasOne("SisConTrad.Core.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SisConTrad.Core.Model.Project", b =>
                {
                    b.HasOne("SisConTrad.Core.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SisConTrad.Core.Model.Translation", b =>
                {
                    b.HasOne("SisConTrad.Core.Model.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
