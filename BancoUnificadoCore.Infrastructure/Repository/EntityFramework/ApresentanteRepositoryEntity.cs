using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Infrastructure.Context;
using System;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.EntityFramework
{
    public class ApresentanteRepositoryEntity : IApresentanteRepository
    {
        protected readonly ContextEntity _context;

        public ApresentanteRepositoryEntity(ContextEntity context)
        {
            _context = context;
        }

        public void Add(Apresentante apresentante)
        {
            _context.Add(apresentante);
            SaveChanges();
        }

        public void Remove(Guid id)
        {
            //_context.Remove(id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public GetApresentanteResult Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool ApresentanteExist(Apresentante apresentante)
        {
            throw new NotImplementedException();
        }

        Apresentante IRepository<Apresentante>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Apresentante> IRepository<Apresentante>.GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Apresentante obj)
        {
            throw new NotImplementedException();
        }
    }
}
