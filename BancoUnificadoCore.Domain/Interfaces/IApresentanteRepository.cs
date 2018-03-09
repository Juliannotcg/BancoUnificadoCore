using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Queries;
using System;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IApresentanteRepository :IRepository<Apresentante>
    {
        void Save(Apresentante apresentante);
        GetApresentanteResult Get(Guid id);
        bool ApresentanteExist(Apresentante apresentante);
    }
}
