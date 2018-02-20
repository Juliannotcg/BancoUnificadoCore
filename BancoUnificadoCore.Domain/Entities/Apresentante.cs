using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Apresentante : Identifier
    {
        public string CodigoApresentante { get; private set; }
        public Pessoa pessoa { get; set; }
    }
}
