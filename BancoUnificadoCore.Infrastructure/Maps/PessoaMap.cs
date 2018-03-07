using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Nome.PrimeiroNome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Nome.SobreNome)
               .HasColumnType("varchar(100)")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(c => c.Documento.TipoDocumento)
                .IsRequired();

            builder.Property(c => c.Documento.NumeroDocumento)
             .HasColumnType("varchar(100)")
             .HasMaxLength(11)
             .IsRequired();

            builder.Property(c => c.Endereco.Logradouro)
             .HasColumnType("varchar(100)")
             .HasMaxLength(11)
             .IsRequired();

            builder.Property(c => c.Endereco.Cidade)
             .HasColumnType("varchar(100)")
             .HasMaxLength(11)
             .IsRequired();


            builder.Property(c => c.Endereco.Bairro)
             .HasColumnType("varchar(100)")
             .HasMaxLength(11)
             .IsRequired();

            builder.Property(c => c.Endereco.Cep)
             .HasColumnType("varchar(100)")
             .HasMaxLength(11)
             .IsRequired();

            builder.Property(c => c.Endereco.Cep)
             .HasColumnType("varchar(100)")
             .HasMaxLength(11)
             .IsRequired();
        }
    }
}
