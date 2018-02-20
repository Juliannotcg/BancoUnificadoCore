using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Pessoa : Identifier
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        public Envolvido envolvido { get; set; }
        public Endereco endereco { get; set; }
    }
}
