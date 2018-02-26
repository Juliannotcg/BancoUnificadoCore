using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Entities;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Envolvido : Entity
    {
        //Construtor Vazio
        public Envolvido(){}
        public Envolvido(TipoEnvolvido tipoEnvolvido, string nomeEnvolvido)
        {
            TipoEnvolvido = tipoEnvolvido;
            NomeEnvolvido = nomeEnvolvido;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(TipoEnvolvido.ToString(), "TipoEnvolvido", "O tipo de envolvido deve ser informado.")
                );
        }

        public TipoEnvolvido TipoEnvolvido { get; private set; }
        public string NomeEnvolvido { get; private set; }
    }
}
