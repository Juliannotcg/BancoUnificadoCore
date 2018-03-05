using BancoUnificadoCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Context
{
    public class ContextEntity : DbContext
    {
        public ContextEntity(DbContextOptions<ContextEntity> options)
            : base(options)
        { }

        public DbSet<Apresentante> Apresentante { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
