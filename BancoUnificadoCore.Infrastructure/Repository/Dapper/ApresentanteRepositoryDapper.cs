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
    }
}
