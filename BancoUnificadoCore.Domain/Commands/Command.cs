using FluentValidation.Results;

namespace BancoUnificadoCore.Domain.Commands
{
    public abstract class Command
    {
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();
    }
}
