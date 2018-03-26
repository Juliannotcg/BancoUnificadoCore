using BancoUnificadoCore.Domain.Entities;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ICargaDiariaRepositoryEntity : IRepository<CargaDiaria>
    {
        void Save(CargaDiaria cargaDiaria);
    }
}
