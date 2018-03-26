using BancoUnificadoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IDevedorRepositoryEntity : IRepository<Devedor>
    {
        void Add(Devedor devedor);
        bool DevedorExist(Devedor devedor);
    }
}

