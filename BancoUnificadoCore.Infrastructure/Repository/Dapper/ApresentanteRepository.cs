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

        public bool ApresentanteExist(Apresentante apresentante)
        {
            string codigoApresentante = apresentante.CodigoApresentante;

            var result = _context.Connection.QueryFirstOrDefault<Pessoa>("SELECT E.AprCodigoApresentante," +
                    "FROM dbo.AprApresentante E " +
                    "WHERE E.AprCodigoApresentante = @CodigoApresentante",
                    new { CodigoApresentante = codigoApresentante });

            return false;
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

            if (!pessoaRepository.PessoaExist(apresentante.Pessoa.Documento))
                pessoaRepository.Save(apresentante.Pessoa);

             _context.Connection.Execute("spCreateApresentante",
             new
             {
                 AprId = apresentante.Id,
                 Apr_PesId = apresentante.Pessoa.Id,
                 AprCodigoApresentante = apresentante.CodigoApresentante
             }, commandType: CommandType.StoredProcedure);
        }
    }
}

