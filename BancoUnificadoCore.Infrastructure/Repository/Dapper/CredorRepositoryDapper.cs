using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class CredorRepositoryDapper : ICredorRepositoryDapper
    {
        private readonly ContextDapper _context;

        public CredorRepositoryDapper(ContextDapper context)
        {
            _context = context;
        }

        public GetCredorResult CheckCredor(string documento)
        {
            return _context
                .Connection
                .Query<GetCredorResult>(
                    "spCheckCredor",
                    new { Documento = documento },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public void Save(Credor credor)
        {
                _context.Connection.Execute("spCreateCredor",
            new
            {
                Id = credor.Id,
                Documento = credor.Documento.NumeroDocumento,
                TipoDocumento = credor.Documento.TipoDocumento,
                Bairro = credor.Endereco.Bairro,
                CEP = credor.Endereco.Cep,
                Cidade = credor.Endereco.Cidade,
                Logradouro = credor.Endereco.Logradouro,
                UF = credor.Endereco.Uf,
                Nome = credor.Nome.PrimeiroNome,
                SobreNome = credor.Nome.SobreNome

            }, commandType: CommandType.StoredProcedure);
        }
    }
}
