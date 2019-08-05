﻿// <auto-generated />
using ClientBasicCrud.Repository.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ClientBasicCrud.Application.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190802041445_InitializeDb")]
    partial class InitializeDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientBasicCrud.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.ToTable("client");

                    b.HasData(
                        new { Id = 1, Birthdate = new DateTime(1994, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Victor Soares", RegistrationDate = new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 2, Birthdate = new DateTime(1980, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Maria Camargo", RegistrationDate = new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
