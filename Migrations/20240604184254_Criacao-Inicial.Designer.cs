﻿// <auto-generated />
using System;
using ApiMissing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiMissing.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240604184254_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiMissing.Models.Observacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObservacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ObservacaoData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacaoData");

                    b.Property<string>("ObservacaoDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoDescricao");

                    b.Property<string>("ObservacaoLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoLocal");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("ApiMissing.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PessoaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PessoaCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaCor");

                    b.Property<DateTime>("PessoaDtDesaparecimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("PessoaDtDesaparecimento");

                    b.Property<DateTime?>("PessoaDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("PessoaDtEncontro");

                    b.Property<string>("PessoaFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaFoto");

                    b.Property<string>("PessoaLocalDesaparecimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaLocalDesaparecimento");

                    b.Property<string>("PessoaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaNome");

                    b.Property<string>("PessoaObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaObservacao");

                    b.Property<string>("PessoaRoupa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaRoupa");

                    b.Property<string>("PessoaSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaSexo");

                    b.Property<byte>("PessoaStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("PessoaStatus");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("ApiMissing.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioName");

                    b.Property<string>("UsuarioPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioPassword");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ApiMissing.Models.Observacoes", b =>
                {
                    b.HasOne("ApiMissing.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiMissing.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ApiMissing.Models.Pessoa", b =>
                {
                    b.HasOne("ApiMissing.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
