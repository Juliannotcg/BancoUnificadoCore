using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class UsuarioMap : BaseMap<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Login)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Senha)
                .IsRequired()
                .HasColumnType("VARCHAR(250)");

            base.Configure(builder);
        }
    }
}
