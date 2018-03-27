using BancoUnificadoCore.Domain.Entities;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ICargaDiariaRepositoryDapper
    {
        void Save(CargaDiaria cargaDiaria);
    }
}
