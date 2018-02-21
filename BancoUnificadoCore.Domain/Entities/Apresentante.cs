using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Apresentante : Identifier
    {
        public Apresentante(string codigoApresentante)
        {
            CodigoApresentante = codigoApresentante;
        }

        public string CodigoApresentante { get; private set; }
        public Pessoa pessoa { get; set; }
    }
}
