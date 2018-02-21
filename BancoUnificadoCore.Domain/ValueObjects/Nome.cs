namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Nome
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = sobreNome;
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }
    }
}
