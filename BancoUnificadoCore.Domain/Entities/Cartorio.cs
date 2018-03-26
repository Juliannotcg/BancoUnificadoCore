using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Cartorio : Entity
    {
        public Cartorio(int codigoCartorio)
        {
            CodigoCartorio = codigoCartorio;
        }

        protected Cartorio() { }

        public int CodigoCartorio { get; private set; }
    }
}
