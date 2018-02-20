using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Cartorio : Identifier
    {
        public Cartorio(int codigoCartorio)
        {
            CodigoCartorio = codigoCartorio;
        }

        public int CodigoCartorio { get; private set; }
    }
}
