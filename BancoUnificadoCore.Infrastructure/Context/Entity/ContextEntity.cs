using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Infrastructure.Class;
using BancoUnificadoCore.Infrastructure.Maps;
using Microsoft.EntityFrameworkCore;

namespace BancoUnificadoCore.Infrastructure.Context
{
    public class ContextEntity : DbContext
    {
        public DbSet<Apresentante> Apresentante { get; set; }
        public DbSet<Devedor> Devedor { get; set; }
        public DbSet<Credor> Credor { get; set; }
        public DbSet<CargaDiaria> CargaDiaria { get; set; }
        public DbSet<Titulo> Titulo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CredorMap());
            modelBuilder.ApplyConfiguration(new DevedorMap());
            modelBuilder.ApplyConfiguration(new ApresentanteMap());
            modelBuilder.ApplyConfiguration(new CargaDiariaMap());
            modelBuilder.ApplyConfiguration(new TituloMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ReadJsonSettings readJsonSettings = new ReadJsonSettings();
            optionsBuilder.UseSqlServer(readJsonSettings.ConnectionString());
        }
    }
}
