﻿// <auto-generated />
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BancoUnificadoCore.Infrastructure.Migrations
{
    [DbContext(typeof(ContextEntity))]
    [Migration("20180402134840_as")]
    partial class @as
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Apresentante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("CodigoApresentante")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Apresentante");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.CargaDiaria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<Guid?>("tituloId");

                    b.HasKey("Id");

                    b.HasIndex("tituloId");

                    b.ToTable("CargaDiaria");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Credor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.HasKey("Id");

                    b.ToTable("Credor");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Devedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<Guid?>("TituloId");

                    b.HasKey("Id");

                    b.HasIndex("TituloId");

                    b.ToTable("Devedor");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Titulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("Acao")
                        .HasColumnName("Acao")
                        .HasColumnType("INT");

                    b.Property<string>("Aceite")
                        .HasColumnName("Aceite")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<Guid?>("ApresentanteId");

                    b.Property<Guid?>("CredorId");

                    b.Property<DateTime>("DataAcao")
                        .HasColumnName("DataAcao")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnName("DataEmissao")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataProtesto")
                        .HasColumnName("DataProtesto")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataProtocolo")
                        .HasColumnName("DataProtocolo")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnName("DataVencimento")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Endosso")
                        .HasColumnName("Endosso")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Especie")
                        .HasColumnName("Especie")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<bool>("FinsFalimentares")
                        .HasColumnName("FinsFalimentares")
                        .HasColumnType("TINYINT");

                    b.Property<int>("Folha")
                        .HasColumnName("Folha")
                        .HasColumnType("INT");

                    b.Property<int>("Livro")
                        .HasColumnName("Livro")
                        .HasColumnType("INT");

                    b.Property<int>("MotivoProtesto")
                        .HasColumnName("MotivoProtesto")
                        .HasColumnType("INT");

                    b.Property<int>("NossoNumero")
                        .HasColumnName("NossoNumero")
                        .HasColumnType("INT");

                    b.Property<int>("Numero")
                        .HasColumnName("Numero")
                        .HasColumnType("INT");

                    b.Property<int>("NumeroProtesto")
                        .HasColumnName("NumeroProtesto")
                        .HasColumnType("INT");

                    b.Property<string>("Protocolo")
                        .HasColumnName("Protocolo")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal>("Saldo")
                        .HasColumnName("Saldo")
                        .HasColumnType("DECIMAL");

                    b.Property<int>("Sequencial")
                        .HasColumnName("Sequencial")
                        .HasColumnType("INT");

                    b.Property<decimal>("Valor")
                        .HasColumnName("Valor")
                        .HasColumnType("DECIMAL");

                    b.HasKey("Id");

                    b.HasIndex("ApresentanteId");

                    b.HasIndex("CredorId");

                    b.ToTable("Titulo");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Apresentante", b =>
                {
                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Documento", "Documento", b1 =>
                        {
                            b1.Property<Guid?>("ApresentanteId");

                            b1.Property<string>("NumeroDocumento")
                                .IsRequired()
                                .HasColumnName("Documento")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<int>("TipoDocumento")
                                .HasColumnName("TipoDocumento")
                                .HasColumnType("VARCHAR(10)");

                            b1.ToTable("Apresentante");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Apresentante")
                                .WithOne("Documento")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Documento", "ApresentanteId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid?>("ApresentanteId");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnName("Bairro")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<string>("Cep")
                                .IsRequired()
                                .HasColumnName("CEP")
                                .HasColumnType("VARCHAR(20)");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnName("Cidade")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnName("Logradouro")
                                .HasColumnType("VARCHAR(150)");

                            b1.Property<string>("Uf")
                                .IsRequired()
                                .HasColumnName("UF")
                                .HasColumnType("VARCHAR(2)");

                            b1.ToTable("Apresentante");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Apresentante")
                                .WithOne("Endereco")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Endereco", "ApresentanteId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Nome", "Nome", b1 =>
                        {
                            b1.Property<Guid?>("ApresentanteId");

                            b1.Property<string>("PrimeiroNome")
                                .IsRequired()
                                .HasColumnName("Nome")
                                .HasColumnType("VARCHAR(150)");

                            b1.Property<string>("SobreNome")
                                .IsRequired()
                                .HasColumnName("SobreNome")
                                .HasColumnType("VARCHAR(150)");

                            b1.ToTable("Apresentante");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Apresentante")
                                .WithOne("Nome")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Nome", "ApresentanteId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.CargaDiaria", b =>
                {
                    b.HasOne("BancoUnificadoCore.Domain.Entities.Titulo", "titulo")
                        .WithMany()
                        .HasForeignKey("tituloId");
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Credor", b =>
                {
                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Documento", "Documento", b1 =>
                        {
                            b1.Property<Guid>("CredorId");

                            b1.Property<string>("NumeroDocumento")
                                .IsRequired()
                                .HasColumnName("Documento")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<int>("TipoDocumento")
                                .HasColumnName("TipoDocumento")
                                .HasColumnType("VARCHAR(10)");

                            b1.ToTable("Credor");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Credor")
                                .WithOne("Documento")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Documento", "CredorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("CredorId");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnName("Bairro")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<string>("Cep")
                                .IsRequired()
                                .HasColumnName("CEP")
                                .HasColumnType("VARCHAR(20)");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnName("Cidade")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnName("Logradouro")
                                .HasColumnType("VARCHAR(150)");

                            b1.Property<string>("Uf")
                                .IsRequired()
                                .HasColumnName("UF")
                                .HasColumnType("VARCHAR(2)");

                            b1.ToTable("Credor");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Credor")
                                .WithOne("Endereco")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Endereco", "CredorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Nome", "Nome", b1 =>
                        {
                            b1.Property<Guid>("CredorId");

                            b1.Property<string>("PrimeiroNome")
                                .IsRequired()
                                .HasColumnName("Nome")
                                .HasColumnType("VARCHAR(150)");

                            b1.Property<string>("SobreNome")
                                .IsRequired()
                                .HasColumnName("SobreNome")
                                .HasColumnType("VARCHAR(150)");

                            b1.ToTable("Credor");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Credor")
                                .WithOne("Nome")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Nome", "CredorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Devedor", b =>
                {
                    b.HasOne("BancoUnificadoCore.Domain.Entities.Titulo")
                        .WithMany("Devedor")
                        .HasForeignKey("TituloId");

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Documento", "Documento", b1 =>
                        {
                            b1.Property<Guid?>("DevedorId");

                            b1.Property<string>("NumeroDocumento")
                                .IsRequired()
                                .HasColumnName("Documento")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<int>("TipoDocumento")
                                .HasColumnName("TipoDocumento")
                                .HasColumnType("VARCHAR(10)");

                            b1.ToTable("Devedor");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Devedor")
                                .WithOne("Documento")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Documento", "DevedorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid?>("DevedorId");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnName("Bairro")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<string>("Cep")
                                .IsRequired()
                                .HasColumnName("CEP")
                                .HasColumnType("VARCHAR(20)");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnName("Cidade")
                                .HasColumnType("VARCHAR(50)");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnName("Logradouro")
                                .HasColumnType("VARCHAR(150)");

                            b1.Property<string>("Uf")
                                .IsRequired()
                                .HasColumnName("UF")
                                .HasColumnType("VARCHAR(2)");

                            b1.ToTable("Devedor");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Devedor")
                                .WithOne("Endereco")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Endereco", "DevedorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("BancoUnificadoCore.Domain.ValueObjects.Nome", "Nome", b1 =>
                        {
                            b1.Property<Guid?>("DevedorId");

                            b1.Property<string>("PrimeiroNome")
                                .IsRequired()
                                .HasColumnName("Nome")
                                .HasColumnType("VARCHAR(150)");

                            b1.Property<string>("SobreNome")
                                .IsRequired()
                                .HasColumnName("SobreNome")
                                .HasColumnType("VARCHAR(150)");

                            b1.ToTable("Devedor");

                            b1.HasOne("BancoUnificadoCore.Domain.Entities.Devedor")
                                .WithOne("Nome")
                                .HasForeignKey("BancoUnificadoCore.Domain.ValueObjects.Nome", "DevedorId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("BancoUnificadoCore.Domain.Entities.Titulo", b =>
                {
                    b.HasOne("BancoUnificadoCore.Domain.Entities.Apresentante", "Apresentante")
                        .WithMany()
                        .HasForeignKey("ApresentanteId");

                    b.HasOne("BancoUnificadoCore.Domain.Entities.Credor", "Credor")
                        .WithMany()
                        .HasForeignKey("CredorId");
                });
#pragma warning restore 612, 618
        }
    }
}
