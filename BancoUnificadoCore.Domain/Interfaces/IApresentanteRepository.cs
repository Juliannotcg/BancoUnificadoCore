﻿using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Queries;
using System;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IApresentanteRepository :IRepository<Apresentante>
    {
        void Add(Apresentante apresentante);
        GetApresentanteResult Get(Guid id);
        bool ApresentanteExist(Apresentante apresentante);
    }
}
