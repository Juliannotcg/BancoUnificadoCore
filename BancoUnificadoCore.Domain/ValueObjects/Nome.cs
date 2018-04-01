using Flunt.Notifications;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3, "Primeiro Nome", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(PrimeiroNome, 40, "Primeiro Nome", "O nome deve conter no máximo 40 caracteres")
                .HasMinLen(SobreNome, 3, "Sobre-Nome", "O sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(SobreNome, 40, "Sobre-Nome", "O sobrenome deve conter no máximo 40 caracteres")
            );
        }

        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
    }
}
