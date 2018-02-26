using BancoUnificadoCore.Shared.ValueObject;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3, "PrimeiroNome", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(SobreNome, 3, "SobreNome", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(PrimeiroNome, 40, "PrimeiroNome", "Nome deve conter até 40 caracteres")
                .HasMaxLen(SobreNome, 40, "SobreNome", "SobreNome deve conter até 40 caracteres")
            );
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}
