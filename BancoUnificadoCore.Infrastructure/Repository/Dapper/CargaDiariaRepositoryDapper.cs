using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Dapper;
using System;
using System.Data;

namespace BancoUnificadoCore.Infrastructure.Repository.Dapper
{
    public class CargaDiariaRepositoryDapper : ICargaDiariaRepositoryDapper
    {
        private readonly ContextDapper _context;
        private readonly TituloRepositoryDapper _tituloRepository;

        public CargaDiariaRepositoryDapper(ContextDapper context, TituloRepositoryDapper tituloRepository)
        {
            _context = context;
            _tituloRepository = tituloRepository;
        }

        public void Save(CargaDiaria cargaDiaria)
        {
            _tituloRepository.Save(cargaDiaria.titulo);

          _context.Connection.Execute("spCreateApresentante",
          new
          {
              Id = cargaDiaria.Id,
              tituloId = cargaDiaria.titulo.Id
          }, commandType: CommandType.StoredProcedure);
        }
    }
}
