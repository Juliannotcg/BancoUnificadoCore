using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class ApresentanteRepositoryDapper : IApresentanteRepositoryDapper
    {
        private readonly ContextDapper _context;

        public ApresentanteRepositoryDapper(ContextDapper context)
        {
            _context = context;
        }
     
        public IEnumerable<GetApresentanteResult> GetAll()
        {
            return _context
                    .Connection
                    .Query<GetApresentanteResult>("spSelectApresentante",
                    new {},
                    commandType: CommandType.StoredProcedure);
        }

        public GetApresentanteResult Get(Guid id)
        {
            return
                _context
                .Connection
                .Query<GetApresentanteResult>("SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [Document], [Email] FROM [Customer] WHERE [Id]=@id", new { id = id })
                .FirstOrDefault();
        }

        public GetApresentanteResult GetByCodigoApresentante(string codigo)
        {
            return _context
                   .Connection
                   .Query<GetApresentanteResult>(
                        "spSelectApresentanteCodigoApresentante",
                         new { CodigoApresentante = codigo },
                        commandType: CommandType.StoredProcedure)
                   .FirstOrDefault();
        }

        public void Save(Apresentante apresentante)
        {
            _context.Connection.Execute("spCreateApresentante",
          new
          {
              Id = apresentante.Id,
              CodigoApresentante = apresentante.CodigoApresentante,
              Documento = apresentante.Documento.NumeroDocumento,
              TipoDocumento = apresentante.Documento.TipoDocumento,
              Bairro = apresentante.Endereco.Bairro,
              CEP = apresentante.Endereco.Cep,
              Cidade = apresentante.Endereco.Cidade,
              Logradouro = apresentante.Endereco.Logradouro,
              UF = apresentante.Endereco.Uf,
              Nome = apresentante.Nome.PrimeiroNome,
              SobreNome = apresentante.Nome.SobreNome
          }, commandType: CommandType.StoredProcedure);
        }

        public GetApresentanteResult CheckApresentante(string documento)
        {
            return _context
                 .Connection
                 .Query<GetApresentanteResult>(
                     "spCheckApresentante",
                     new { Documento = documento },
                     commandType: CommandType.StoredProcedure)
                 .FirstOrDefault();
        }
    }
}
