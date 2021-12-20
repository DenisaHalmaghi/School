﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211214084228_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Note", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Studentid")
                        .HasColumnType("int");

                    b.Property<string>("disciplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_student")
                        .HasColumnType("int");

                    b.Property<decimal>("media")
                        .HasColumnType("decimal(2,1)");

                    b.Property<decimal>("nota1")
                        .HasColumnType("decimal(2,1)");

                    b.Property<decimal>("nota2")
                        .HasColumnType("decimal(2,1)");

                    b.HasKey("id");

                    b.HasIndex("Studentid");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("WebApplication3.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApplication3.Models.Note", b =>
                {
                    b.HasOne("WebApplication3.Models.Student", null)
                        .WithMany("Note")
                        .HasForeignKey("Studentid");
                });

            modelBuilder.Entity("WebApplication3.Models.Student", b =>
                {
                    b.Navigation("Note");
                });
#pragma warning restore 612, 618
        }
    }
}
