using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Queries;
using System;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IApresentanteRepository 
    {
        void Save(Apresentante apresentante);
        GetApresentanteResult Get(Guid id);
    }
}
