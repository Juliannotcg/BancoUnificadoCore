using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared;
using BancoUnificadoCore.Shared.ValueObject;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        private ValidateCNPJCPF validate;

        public Documento(ETipoDocumento tipoDocumento, string numeroDocumento)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(ValidarDocumento(), "NumeroDocumento", "Documento inválido")
                );
        }
        public ETipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public bool ValidarDocumento()
        {
            validate = new ValidateCNPJCPF();

            if (validate.isCPFCNPJ(NumeroDocumento))
                return true;
            else
                return false;
        }
    }
}
