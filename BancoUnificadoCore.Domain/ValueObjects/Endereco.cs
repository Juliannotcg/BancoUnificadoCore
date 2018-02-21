using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class Endereco 
    {
        public Endereco(string logradouro, string bairro, string cidade, string uf, string cep)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
        }

        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Cep { get; private set; }
    }
}
