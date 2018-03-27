using BancoUnificadoCore.Domain.Commands;
using FluentValidation;

namespace BancoUnificadoCore.Domain.Validations.Devedor
{
    public class DevedorValidation<T> : AbstractValidator<T> where T : CommandDevedor
    {
        protected void ValidateNomeDevedor()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do devedor ser preenchido.")
                .Length(2, 10).WithMessage("O nome do devedor deve conter entre 2 e 100 caracteres.");
        }

        protected void ValidateSobreNomeDevedor()
        {
            RuleFor(c => c.SobreNome)
                .NotEmpty().WithMessage("O sobre-nome do devedor deve ser preenchido.")
                .Length(2, 10).WithMessage("O sobre-nome do devedor deve conter entre 2 e 10 caracteres.")
                .NotEqual(x => x.Nome).WithMessage("o sobre-nome não pode ser igual ao nome.");
        }
        protected void ValidateDocumentoDevedor()
        {
            RuleFor(c => c.NumeroDocumento)
                .NotEmpty().WithMessage("O documento do apresentante deve ser preenchido.")
                .Length(11, 14).WithMessage("O documento do apresentante deve conter entre 11 e 14 caracteres.");
        }
    }
}
