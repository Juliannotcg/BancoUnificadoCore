using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.Validations;
using FluentValidation.Results;

namespace BancoUnificadoCore.Domain.Commands
{
    public class CommandCreateApresentante : CommandApresentante
    {
        public override bool IsValid()
        {
            ValidationResult = new NewCreateApresentanteCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
