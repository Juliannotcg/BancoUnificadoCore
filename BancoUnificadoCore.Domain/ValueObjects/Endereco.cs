using Flunt.Notifications;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.ValueObjects
{
    public class Endereco : Notifiable
    {
        public Endereco(string logradouro, string bairro, string cidade, string uf, string cep)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Logradouro, 3, "Logradouro", "O logradouro deve conter pelo menos 3 caracteres")
                .HasMinLen(Bairro, 3, "Bairro", "O bairro deve conter pelo menos 3 caracteres")
                .HasMinLen(Cidade, 3, "Cidade", "O cidade deve conter pelo menos 3 caracteres")
                .HasMinLen(Uf, 1, "Uf", "A unidade federativa deve conter pelo menos 1 caractere")
                .HasMaxLen(Uf, 2, "Uf", "A unidade federativa deve conter até 2 caractere")
                .HasMaxLen(Cep, 8, "Cep", "O cep deve conter até 8 caracteres")
                );
        }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
    }
}
