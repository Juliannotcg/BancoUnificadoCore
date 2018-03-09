using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class ApresentanteMap : IEntityTypeConfiguration<Apresentante>
    {
        public void Configure(EntityTypeBuilder<Apresentante> builder)
        {


            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.CodigoApresentante)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");
            
        }
    }
}
