using BancoUnificadoCore.Shared.ValueObject;
using Flunt.Validations;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Endereco : ValueObject
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
                .IsNullOrEmpty(Logradouro, "Endereco.Logradouro", "Endereco inválido")
                .IsNullOrEmpty(Bairro, "Endereco.Bairro", "Bairro inválido")
                .IsNullOrEmpty(Cidade, "Endereco.Cidade", "Cidade inválida")
            );
        }

        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Cep { get; private set; }
    }
}
