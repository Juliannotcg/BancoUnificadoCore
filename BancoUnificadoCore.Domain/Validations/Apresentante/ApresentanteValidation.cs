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
        protected void ValidateNomeApresentante()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do apresentante deve ser preenchido.")
                .Length(2, 10).WithMessage("O nome do apresentante deve conter entre 2 e 10 caracteres.");
        }
        protected void ValidateSobreNomeApresentante()
        {
            RuleFor(c => c.SobreNome)
                .NotEmpty().WithMessage("O sobre-nome do apresentante deve ser preenchido.")
                .Length(2, 10).WithMessage("O sobre-nome do apresentante deve conter entre 2 e 10 caracteres.");
        }
        protected void ValidateDocumentoApresentante()
        {
            RuleFor(c => c.NumeroDocumento)
                .NotEmpty().WithMessage("O documento do apresentante deve ser preenchido.")
                .Length(11, 14).WithMessage("O sobre-nome do apresentante deve conter entre 2 e 10 caracteres.");
        }
    }
}
