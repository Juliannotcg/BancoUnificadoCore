using BancoUnificadoCore.Domain.Commands;
using FluentValidation;

namespace BancoUnificadoCore.Domain.Validations.CargaDiaria
{
    public class CargaDiariaValidation<T> : AbstractValidator<T> where T : CommandCreateCargaDiaria
    {
        protected void ValidateCargaDiaria()
        {
            RuleFor(c => c.Protocolo)
                .NotEmpty().WithMessage("O protocolo deve ser preenchido.")
                .Length(2, 10).WithMessage("O código do apresentante deve conter entre 2 e 10 caracteres.");
        }
    }
}
