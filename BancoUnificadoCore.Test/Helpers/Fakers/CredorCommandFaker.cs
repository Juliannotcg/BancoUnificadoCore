using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Domain.Enums;
using Bogus;

namespace BancoUnificadoCore.Test.Helpers.Fakers
{
    public static class CredorCommandFaker
    {
        public static Faker<CommandCreateCredor> Gerar()
        {
            Faker<CommandCreateCredor> credor = new Faker<CommandCreateCredor>()
                   .RuleFor(c => c.Nome, f => f.Name.FirstName())
                   .RuleFor(c => c.SobreNome, f => f.Name.LastName())
                   .RuleFor(c => c.NumeroDocumento, f => f.Random.Int(0, 1000000).ToString())
                   .RuleFor(c => c.TipoDocumento, f => f.PickRandom<ETipoDocumento>())
                   .RuleFor(c => c.Endereco, f => f.Address.StreetAddress())
                   .RuleFor(c => c.Bairro, f => f.Address.Random.String())
                   .RuleFor(c => c.Cidade, f => f.Address.City())
                   .RuleFor(c => c.Uf, f => f.Address.Country().Substring(0, 1))
                   .RuleFor(c => c.CEP, f => f.Address.ZipCode());

            return credor;
        }
    }
}
