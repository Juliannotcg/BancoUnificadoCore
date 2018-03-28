using BancoUnificadoCore.Domain.Queries;
using System.Collections.Generic;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IDevedorRepositoryDapper 
    {
        IEnumerable<GetDevedorResult> GetAll();
        GetDevedorResult GetByDocumentoDevedor(string documento);
        bool CheckDevedor (string documento);
    }
}
