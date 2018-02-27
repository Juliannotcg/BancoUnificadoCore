using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Pessoa : Entity
    {
        //Construtor vazio.
        public Pessoa(){}

        public Pessoa(Nome nome, Documento documento, Endereco endereco, ETipoEnvolvido tipoEnvolvido)
        {
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
            TipoEnvolvido = tipoEnvolvido;
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public ETipoEnvolvido TipoEnvolvido { get; private set; }
        public Endereco Endereco { get; set; }
    }
}
