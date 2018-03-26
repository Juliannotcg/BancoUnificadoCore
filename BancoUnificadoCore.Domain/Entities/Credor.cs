using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Credor : Entity
    {
        public Credor(){}

        public Credor(Nome nome, Documento documento, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
