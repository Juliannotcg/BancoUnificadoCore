using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Infrastructure.Context;
using BancoUnificadoCore.Infrastructure.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Infrastructure.Repository.EntityFramework
{
    public class ApresentanteRepositoryEntity : Repository<Apresentante>, IApresentanteRepository
    {
        public ApresentanteRepositoryEntity(ContextEntity context)
            : base(context)
        {

        }

        public bool ApresentanteExist(Apresentante apresentante)
        {
            throw new NotImplementedException();
        }

        public GetApresentanteResult Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Apresentante apresentante)
        {
            throw new NotImplementedException();
        }
    }
}
