using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Queries;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ICredorRepositoryDapper
    {
        void Save(Credor credor);
        GetCredorResult CheckCredor(string documento);
    }
}
