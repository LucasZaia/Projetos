﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projetos.database;

namespace Projetos.Migrations
{
    [DbContext(typeof(DbProvider))]
    [Migration("20210927155852_ghf")]
    partial class ghf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Projetos.Data.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("senha")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("idUser");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
