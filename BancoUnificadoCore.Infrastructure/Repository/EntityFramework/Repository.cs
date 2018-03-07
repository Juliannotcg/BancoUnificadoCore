using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BancoUnificadoCore.Infrastructure.Repository.Entity
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ContextEntity _context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ContextEntity context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
