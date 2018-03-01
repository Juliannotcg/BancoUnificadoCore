using BancoUnificadoCore.Domain.Entities;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ICargaDiariaRepository
    {
        void Save(CargaDiaria cargaDiaria);
    }
}
