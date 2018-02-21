using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Pessoa : Identifier
    {
        public Pessoa(Nome nome, TipoDocumento tipoDocumento, string documento)
        {
            Nome = nome;
            TipoDocumento = tipoDocumento;
            Documento = documento;
        }

        public Nome Nome { get; private set; }
        public TipoDocumento TipoDocumento { get; private set; }
        public string Documento { get; private set; }
        public Envolvido envolvido { get; private set; }
        public Endereco endereco { get; private set; }
    }
}
