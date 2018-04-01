using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Shared;
using Flunt.Notifications;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Documento : Notifiable
    {
        private ValidateCNPJCPF validate;

        public Documento(ETipoDocumento tipoDocumento, string numeroDocumento)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;

            AddNotifications(new Contract()
                .IsTrue(ValidarDocumento(NumeroDocumento), "Documento", "Número de documento inválido")
            );
        }
        public ETipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public bool ValidarDocumento(string NumeroDocumento)
        {
            validate = new ValidateCNPJCPF();

            if (validate.isCPFCNPJ(NumeroDocumento))
                return true;
            else
                return false;
        }
    }
}
