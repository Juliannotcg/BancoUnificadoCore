using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using System;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.EntityFramework
{
    public class CargaDiariaRepositoryEntity : ICargaDiariaRepositoryEntity
    {
        protected readonly ContextEntity _context;

        public CargaDiariaRepositoryEntity(ContextEntity context)
        {
            _context = context;
        }

        public void Add(CargaDiaria obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<CargaDiaria> GetAll()
        {
            throw new NotImplementedException();
        }

        public CargaDiaria GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(CargaDiaria cargaDiaria)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(CargaDiaria obj)
        {
            throw new NotImplementedException();
        }
    }
}
