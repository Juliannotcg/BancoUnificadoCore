using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Class
{
    public class ReadJsonSettings
    {
        public string ConnectionString()
        {
            return GetConnectionString();
        }

        private string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return (config.GetConnectionString("connectionString"));
        }
    }
}
