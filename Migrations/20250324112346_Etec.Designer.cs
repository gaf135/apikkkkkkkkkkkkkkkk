﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apikkkkkkkkkkkkkkkk.Data;

#nullable disable

namespace apikkkkkkkkkkkkkkkk.Migrations
{
    [DbContext(typeof(apikkkkkkkkkkkkkkkkContext))]
    [Migration("20250324112346_Etec")]
    partial class Etec
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apikkkkkkkkkkkkkkkk.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EscolaID")
                        .HasColumnType("int");

                    b.Property<string>("Mae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessorID")
                        .HasColumnType("int");

                    b.Property<string>("RMA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("apikkkkkkkkkkkkkkkk.Models.Escola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("apikkkkkkkkkkkkkkkk.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlunoID")
                        .HasColumnType("int");

                    b.Property<string>("ComponenteCurricular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EscolaID")
                        .HasColumnType("int");

                    b.Property<string>("Mae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RMA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });
#pragma warning restore 612, 618
        }
    }
}
