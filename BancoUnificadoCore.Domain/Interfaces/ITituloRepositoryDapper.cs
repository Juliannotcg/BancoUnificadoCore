using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Queries.Titulo;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ITituloRepositoryDapper
    {
        void Save(Titulo titulo);
        IEnumerable<GetTituloResult> GetAll();
        GetTituloResult GetById(Guid Id);
        GetTituloResult GetTituloProtocolo(string protocolo);
    }
}
