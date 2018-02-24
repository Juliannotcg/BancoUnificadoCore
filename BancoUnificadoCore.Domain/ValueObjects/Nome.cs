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
                .HasMinLen(PrimeiroNome, 3, "Name.PrimeiroNome", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(SobreNome, 3, "Name.SobreNome", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(PrimeiroNome, 40, "Name.PrimeiroNome", "Nome deve conter até 40 caracteres")
                .HasMaxLen(SobreNome, 40, "Name.SobreNome", "SobreNome deve conter até 40 caracteres")
            );
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}
