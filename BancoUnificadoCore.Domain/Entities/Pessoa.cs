using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa(Nome nome, Documento documento, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Envolvido envolvido { get; private set; }
        public Endereco Endereco { get; set; }
    }
}
