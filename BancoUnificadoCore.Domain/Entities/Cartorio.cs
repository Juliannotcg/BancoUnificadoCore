using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Cartorio : Entity
    {
        public Cartorio(){}

        public Cartorio(int codigoCartorio)
        {
            CodigoCartorio = codigoCartorio;
        }

        public int CodigoCartorio { get; private set; }
    }
}
