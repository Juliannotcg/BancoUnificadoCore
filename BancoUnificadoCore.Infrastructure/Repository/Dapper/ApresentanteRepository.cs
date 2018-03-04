using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Data;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class ApresentanteRepository : IApresentanteRepository
    {
        private readonly ContextDapper _context;
        private PessoaRepository pessoaRepository;

        public ApresentanteRepository(ContextDapper context)
        {
            _context = context;
        }

        public GetApresentanteResult Get(Guid id)
        {
            return
                _context
                .Connection
                .Query<GetApresentanteResult>("SELECT [Id], CONCAT([PrimeiroNome], ' ', [SobreNome]) AS [Nome], [Documento], [CodigoApresentante] FROM [Apresentante] WHERE [Id]=@id", new { id = id })
                .FirstOrDefault();
        }

        public void Save(Apresentante apresentante)
        {
            pessoaRepository = new PessoaRepository(_context);
            pessoaRepository.Save(apresentante.Pessoa);

            string insertQueryApresentante = "INSERT INTO AprApresentante (AprId, Apr_PesId, AprCodigoApresentante)"
                          + " VALUES(@Id, @Id @CodigoApresentante)";

            var resultApr = _context.Connection.Execute(insertQueryApresentante, new
            {
                apresentante.Id,
                //apresentante.Pessoa.Id,
                apresentante.CodigoApresentante
            });
            
        }
    }
}

