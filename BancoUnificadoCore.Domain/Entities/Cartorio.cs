using BancoUnificadoCore.Shared.Entities;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Cartorio : Entity
    {
        public Cartorio(){}

        public Cartorio(int codigoCartorio)
        {
            CodigoCartorio = codigoCartorio;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(CodigoCartorio.ToString(), "CodigoCartorio", "O código do cartório deve ser informado.")
                );
        }

        public int CodigoCartorio { get; private set; }
    }
}
