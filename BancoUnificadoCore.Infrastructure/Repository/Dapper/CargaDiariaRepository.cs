using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System.Data;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class CargaDiariaRepository : ICargaDiariaRepository
    {
        private readonly ContextDapper _context;

        public CargaDiariaRepository(ContextDapper context)
        {
            _context = context;
        }

        public void Save(CargaDiaria cargaDiaria)
        {
            _context.Connection.Execute("spCreateApresentane",
            new
            {
                //Id = cargaDiaria.Id,
                //FirstName = apresentante.pessoa.Nome.PrimeiroNome,
                //SegundoNome = apresentante.pessoa.Nome.SobreNome,
                //Documento = apresentante.pessoa.Documento,
                //CodigoApresentane = apresentante.CodigoApresentante
            }, commandType: CommandType.StoredProcedure);
        }
    }
}
