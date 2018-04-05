using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Enums;
using Bogus;

namespace BancoUnificadoCore.Test.Helpers.Fakers
{
    public static class ApresentanteCommandFaker 
    {
        public static Faker<CommandCreateApresentante> Gerar()
        {
            Faker<CommandCreateApresentante> apresentante = new Faker<CommandCreateApresentante>()
                .RuleFor(a => a.CodigoApresentante, f => f.Random.Int(6, 6).ToString())
                .RuleFor(a => a.Nome, f => f.Name.FirstName())
                .RuleFor(a => a.SobreNome, f => f.Name.LastName())
                .RuleFor(a => a.NumeroDocumento, f => f.Random.Int(0, 1000000).ToString())
                .RuleFor(a => a.TipoDocumento, f => f.PickRandom<ETipoDocumento>())
                .RuleFor(a => a.Endereco, f => f.Address.StreetAddress())
                .RuleFor(a => a.Bairro, f => f.Address.Random.String())
                .RuleFor(a => a.Cidade, f => f.Address.City())
                .RuleFor(a => a.Uf, f => f.Address.Country().Substring(0, 1))
                .RuleFor(a => a.CEP, f => f.Address.ZipCode());

            return apresentante;
        }
    }
}
