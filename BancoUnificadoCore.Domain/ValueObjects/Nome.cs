using BancoUnificadoCore.Shared.ValueObject;

namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }

        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
    }
}
