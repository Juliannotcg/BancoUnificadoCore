using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using System;

namespace BancoUnificadoCore.Infrastructure.Repository.EntityFramework
{
    public class DevedorRepositoryEntity : IDevedorRepositoryEntity
    {
        protected readonly ContextEntity _context;

        public DevedorRepositoryEntity(ContextEntity context)
        {
            _context = context;
        }

        public void Add(Devedor devedor)
        {
            _context.Add(devedor);
            SaveChanges();
        }

        public bool DevedorExist(Devedor devedor)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(Devedor obj)
        {
            throw new NotImplementedException();
        }
    }
}
