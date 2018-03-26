using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Maps
{
    public class CargaDiariaMap : BaseMap<CargaDiaria>
    {
        public override void Configure(EntityTypeBuilder<CargaDiaria> builder)
        {
            builder.ToTable("CargaDiaria");

            builder.Property(c => c.Id)
                .HasColumnName("Id");
            
            base.Configure(builder);
        }
    }
}
