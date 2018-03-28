using BancoUnificadoCore.Domain.Entities;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface ITituloRepositoryDapper
    {
        void Save(Titulo titulo);
    }
}
