using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BancoUnificadoCore.Infrastructure.Context
{
    public class BancoUnificadoCoreContext : DbContext
    {
        public DbSet<Apresentante> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApresentanteMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
