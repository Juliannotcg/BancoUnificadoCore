using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Enums;
using Bogus;

namespace BancoUnificadoCore.Test.Helpers.Fakers
{
    public static class DevedorCommandFaker
    {
        public static Faker<CommandDevedor> Gerar()
        {
            Faker<CommandDevedor> devedor = new Faker<CommandDevedor>()
                   .RuleFor(d => d.Nome, f => f.Name.FirstName())
                   .RuleFor(d => d.SobreNome, f => f.Name.LastName())
                   .RuleFor(d => d.NumeroDocumento, f => f.Random.Int(0, 1000000).ToString())
                   .RuleFor(d => d.TipoDocumento, f => f.PickRandom<ETipoDocumento>())
                   .RuleFor(d => d.Endereco, f => f.Address.StreetAddress())
                   .RuleFor(d => d.Bairro, f => f.Address.Random.String())
                   .RuleFor(d => d.Cidade, f => f.Address.City())
                   .RuleFor(d => d.Uf, f => f.Address.Country().Substring(0, 1))
                   .RuleFor(d => d.CEP, f => f.Address.ZipCode());

            return devedor;
        }
    }
}
