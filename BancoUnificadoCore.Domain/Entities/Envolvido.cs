using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Envolvido : Identifier
    {
        public TipoEnvolvido TipoEnvolvido { get; set; }
        public string NomeEnvolvido { get; set; }
    }
}
