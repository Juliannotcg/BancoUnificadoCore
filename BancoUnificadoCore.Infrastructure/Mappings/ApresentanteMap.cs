using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoUnificadoCore.Infrastructure.Mappings
{
    public class ApresentanteMap : IEntityTypeConfiguration<Apresentante>
    {
        public void Configure(EntityTypeBuilder<Apresentante> builder)
        {
            builder.Property(c => c.Id);

            builder.Property(c => c.CodigoApresentante)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
