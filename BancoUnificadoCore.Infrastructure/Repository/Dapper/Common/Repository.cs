using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace BancoUnificadoCore.Infrastructure.Repository.Dapper.Common
{
    public class Repository : IDisposable
    {
        private IConfiguration _configuracoes;
        private SqlConnection connection;

        public Repository(IConfiguration config)
        {
            _configuracoes = config;
        }

        public IDbConnection Connection()
        {
            return connection = new SqlConnection(_configuracoes.GetConnectionString("BaseBancoUnificadoCore"));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

