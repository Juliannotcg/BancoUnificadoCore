using BancoUnificadoCore.Infrastructure.Class;
using BancoUnificadoCore.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Context
{
    public class ContextDapper : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public ContextDapper()
        {
            ReadJsonSettings readJsonSettings = new ReadJsonSettings();
            Connection = new SqlConnection(readJsonSettings.ConnectionString());
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
