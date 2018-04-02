using BancoUnificadoCore.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Ignore(c => c.Notifications);
            builder.Ignore(c => c.Invalid);
            builder.Ignore(c => c.Valid);

        }
    }
}
