using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
