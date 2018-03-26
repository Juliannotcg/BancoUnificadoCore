using BancoUnificadoCore.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IApresentanteRepositoryDapper
    {
        IEnumerable<GetApresentanteResult> GetAll();

        GetApresentanteResult GetByCodigoApresentante(string codigo);
    }
}
