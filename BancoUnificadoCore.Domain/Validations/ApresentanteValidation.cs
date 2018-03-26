using BancoUnificadoCore.Domain.Commands;
using FluentValidation;

namespace BancoUnificadoCore.Domain.Validations
{
    public class ApresentanteValidation<T> : AbstractValidator<T> where T : CommandApresentante
    {
        protected void ValidateCodigoApresentante()
        {
            RuleFor(c => c.CodigoApresentante)
                .NotEmpty().WithMessage("O código do apresentante deve ser preenchido.")
                .Length(2, 10).WithMessage("O código do apresentante deve conter entre 2 e 10 caracteres.");
        }
    }
}
