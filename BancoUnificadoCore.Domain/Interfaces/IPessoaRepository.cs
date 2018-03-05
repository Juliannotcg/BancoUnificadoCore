using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.ValueObjects;

namespace BancoUnificadoCore.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        void Save(Pessoa pessoa);

        bool PessoaExist(Documento documento);
    }
}
