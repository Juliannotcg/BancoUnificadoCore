using BancoUnificadoCore.Domain.Commands;

namespace BancoUnificadoCore.Domain.Validations
{
    public class NewCreateApresentanteCommandValidation : ApresentanteValidation<CommandCreateApresentante>
    {
        public NewCreateApresentanteCommandValidation()
        {
            ValidateCodigoApresentante();
        }
    }
}
