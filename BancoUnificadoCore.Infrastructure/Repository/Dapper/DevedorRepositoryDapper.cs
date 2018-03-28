using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class DevedorRepositoryDapper : IDevedorRepositoryDapper
    {
        private readonly ContextDapper _context;

        public DevedorRepositoryDapper(ContextDapper context)
        {
            _context = context;
        }

        public bool CheckDevedor(string documento)
        {
            return _context
                .Connection
                .Query<bool>(
                    "spCheckDevedor",
                    new { Documento = documento },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public IEnumerable<GetDevedorResult> GetAll()
        {
            return _context
                    .Connection
                    .Query<GetDevedorResult>("spSelectApresentante",
                    new { },
                    commandType: CommandType.StoredProcedure);
        }

        public GetDevedorResult GetByDocumentoDevedor(string documento)
        {
            return _context
                 .Connection
                 .Query<GetDevedorResult>(
                      "spSelectDevedorDocumento",
                       new { DocumentoDevedor = documento },
                      commandType: CommandType.StoredProcedure)
                      .FirstOrDefault();
        }

        public void Save(Titulo titulo)
        {
            foreach (var item in titulo.Devedor)
            {
                _context.Connection.Execute("spCreateDevedor",
                 new
                 {
                     Id = item.Id,
                     TituloId = titulo.Id,
                     Documento = item.Documento.NumeroDocumento,
                     TipoDocumento = item.Documento.TipoDocumento,
                     Bairro = item.Endereco.Bairro,
                     CEP = item.Endereco.Cep,
                     Cidade = item.Endereco.Cidade,
                     Logradouro = item.Endereco.Logradouro,
                     UF = item.Endereco.Uf,
                     Nome = item.Nome.PrimeiroNome,
                     SobreNome = item.Nome.SobreNome
                 }, commandType: CommandType.StoredProcedure);
            }
         
        }
    }
}
