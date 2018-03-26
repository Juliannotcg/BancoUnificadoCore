using BancoUnificadoCore.Domain.Entities;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ICargaDiariaRepository : IRepository<CargaDiaria>
    {
        void Save(CargaDiaria cargaDiaria);
    }
}
