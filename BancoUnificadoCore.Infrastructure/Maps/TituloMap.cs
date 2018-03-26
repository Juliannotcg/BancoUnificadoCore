using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class TituloMap : BaseMap<Titulo>
    {
        public override void Configure(EntityTypeBuilder<Titulo> builder)
        {
            builder.ToTable("Titulo");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Acao)
               .HasColumnType("INT")
               .HasColumnName("Acao");

            builder.Property(c => c.Aceite)
               .HasColumnType("VARCHAR(20)")
               .HasColumnName("Aceite");

            builder.Property(c => c.DataAcao)
               .HasColumnType("DATETIME")
               .HasColumnName("DataAcao");

            builder.Property(c => c.DataEmissao)
               .HasColumnType("DATETIME")
               .HasColumnName("DataEmissao");

            builder.Property(c => c.DataProtesto)
               .HasColumnType("DATETIME")
               .HasColumnName("DataProtesto");
            
            builder.Property(c => c.DataProtocolo)
               .HasColumnType("DATETIME")
               .HasColumnName("DataProtocolo");

            builder.Property(c => c.DataVencimento)
               .HasColumnType("DATETIME")
               .HasColumnName("DataVencimento");

            builder.Property(c => c.Endosso)
               .HasColumnType("VARCHAR(20)")
               .HasColumnName("Endosso");

            builder.Property(c => c.Especie)
               .HasColumnType("VARCHAR(50)")
               .HasColumnName("Especie");

            builder.Property(c => c.FinsFalimentares)
               .HasColumnType("TINYINT")
               .HasColumnName("FinsFalimentares");

            builder.Property(c => c.Folha)
               .HasColumnType("INT")
               .HasColumnName("Folha");

            builder.Property(c => c.Livro)
               .HasColumnType("INT")
               .HasColumnName("Livro");

            builder.Property(c => c.MotivoProtesto)
               .HasColumnType("INT")
               .HasColumnName("MotivoProtesto");

            builder.Property(c => c.NossoNumero)
               .HasColumnType("INT")
               .HasColumnName("NossoNumero");

            builder.Property(c => c.Numero)
               .HasColumnType("INT")
               .HasColumnName("Numero");

            builder.Property(c => c.NumeroProtesto)
               .HasColumnType("INT")
               .HasColumnName("NumeroProtesto");

            builder.Property(c => c.Protocolo)
               .HasColumnType("VARCHAR(100)")
               .HasColumnName("Protocolo");

            builder.Property(c => c.Saldo)
               .HasColumnType("DECIMAL")
               .HasColumnName("Saldo");

            builder.Property(c => c.Sequencial)
               .HasColumnType("INT")
               .HasColumnName("Sequencial");

            builder.Property(c => c.Valor)
               .HasColumnType("DECIMAL")
               .HasColumnName("Valor");

            base.Configure(builder);
        }
    }
}
