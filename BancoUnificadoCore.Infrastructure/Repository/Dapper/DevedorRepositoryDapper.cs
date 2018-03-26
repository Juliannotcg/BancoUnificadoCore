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
    public class DevedorRepositoryDapper : IDevedorRepositoryDapper
    {
        private readonly ContextDapper _context;

        public DevedorRepositoryDapper(ContextDapper context)
        {
            _context = context;
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
    }
}
