using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa(Nome nome, TipoDocumento tipoDocumento, string documento, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            TipoDocumento = tipoDocumento;
            Documento = documento;

            AddNotifications(Nome, Endereco);
        }

        public Nome Nome { get; private set; }
        public TipoDocumento TipoDocumento { get; private set; }
        public string Documento { get; private set; }
        public Envolvido envolvido { get; private set; }
        public Endereco Endereco { get; set; }
    }
}
