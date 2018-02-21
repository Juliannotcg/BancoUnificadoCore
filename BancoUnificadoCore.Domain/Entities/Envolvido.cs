using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Envolvido : Identifier
    {
        public Envolvido(TipoEnvolvido tipoEnvolvido, string nomeEnvolvido)
        {
            TipoEnvolvido = tipoEnvolvido;
            NomeEnvolvido = nomeEnvolvido;
        }

        public TipoEnvolvido TipoEnvolvido { get; private set; }
        public string NomeEnvolvido { get; private set; }
    }
}
