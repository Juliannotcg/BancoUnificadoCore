using BancoUnificadoCore.Domain.Entities;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ICredorRepositoryDapper
    {
        void Save(Credor credor);
        bool CheckCredor (string documento);
    }
}
