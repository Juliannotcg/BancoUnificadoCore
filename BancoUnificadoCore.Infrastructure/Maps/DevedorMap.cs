using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class DevedorMap : BaseMap<Devedor>
    {
        public override void Configure(EntityTypeBuilder<Devedor> builder)
        {
            builder.ToTable("Devedor");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.OwnsOne(c => c.Nome, nome =>
            {
                nome.Property(c => c.PrimeiroNome)
                 .IsRequired()
                 .HasColumnName("Nome")
                 .HasColumnType("VARCHAR(150)");

                nome.Property(c => c.SobreNome)
                 .IsRequired()
                 .HasColumnName("SobreNome")
                 .HasColumnType("VARCHAR(150)");
            });


            builder.OwnsOne(c => c.Documento, documento =>
            {
                documento.Property(c => c.TipoDocumento)
                .IsRequired()
                .HasColumnName("TipoDocumento")
                .HasColumnType("VARCHAR(10)");

                documento.Property(c => c.NumeroDocumento)
               .IsRequired()
               .HasColumnName("Documento")
               .HasColumnType("VARCHAR(50)");
            });


            builder.OwnsOne(c => c.Endereco, endereco =>
            {
                endereco.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnName("Bairro")
                .HasColumnType("VARCHAR(50)");

                endereco.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnName("Cidade")
                .HasColumnType("VARCHAR(50)");

                endereco.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnName("Logradouro")
                .HasColumnType("VARCHAR(150)");

                endereco.Property(c => c.Cep)
                .IsRequired()
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR(20)");

                endereco.Property(c => c.Uf)
                .IsRequired()
                .HasColumnName("UF")
                .HasColumnType("VARCHAR(2)");
            });

            base.Configure(builder);
        }
    }
}
