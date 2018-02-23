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
            _context.Connection.Execute("spCreateApresentane",
            new
            {
                Id = apresentante.Id,
                FirstName = apresentante.pessoa.Nome.PrimeiroNome,
                SegundoNome = apresentante.pessoa.Nome.SegundoNome,
                Documento = apresentante.pessoa.Documento,
                CodigoApresentane = apresentante.CodigoApresentante
            }, commandType: CommandType.StoredProcedure);
        }
    }
}

