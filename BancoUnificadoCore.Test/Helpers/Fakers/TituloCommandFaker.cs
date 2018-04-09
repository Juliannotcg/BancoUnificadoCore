using BancoUnificadoCore.Domain.Commands.Titulo;
using BancoUnificadoCore.Domain.Enums;
using Bogus;
using System;

namespace BancoUnificadoCore.Test.Helpers.Fakers
{
    public static class TituloCommandFaker
    {
        private static readonly Random random = new Random();

        public static Faker<CommandCreateTitulo> Gerar()
        {
            Faker<CommandCreateTitulo> titulo = new Faker<CommandCreateTitulo>()
                   .RuleFor(t => t.Protocolo, f => f.Random.Int(1, 10).ToString())
                   .RuleFor(t => t.Livro, f => f.Random.Int(1, 5))
                   .RuleFor(t => t.Folha, f => f.Random.Int(1, 5))
                   .RuleFor(t => t.NumeroProtesto, f => f.Random.Int(1, 8))
                   .RuleFor(t => t.Especie, f => f.Lorem.Word().ToString())
                   .RuleFor(t => t.Numero, f => f.Random.Int(1, 5))
                   .RuleFor(t => t.NossoNumero, f => f.Random.Int(1, 10))
                   .RuleFor(t => t.Valor, f => f.Random.Decimal())
                   .RuleFor(t => t.Saldo, f => f.Random.Decimal())
                   .RuleFor(t => t.Endosso, f => f.Lorem.Letter(1))
                   .RuleFor(t => t.Aceite, f => f.Lorem.Random.String(3, 'S', 'N'))
                   .RuleFor(t => t.FinsFalimentares, f => RetornaBool(random))
                   .RuleFor(t => t.MotivoProtesto, f => f.Random.Int(1, 2))
                   .RuleFor(t => t.Sequencial, f => f.Random.Int(1, 15))
                   .RuleFor(t => t.CodigoCartorio, f => f.Random.Int(1, 10))
                   .RuleFor(t => t.Apresentante, f => ApresentanteCommandFaker.Gerar())
                   .RuleFor(t => t.Credor, f => CredorCommandFaker.Gerar())
                   .RuleFor(t => t.Devedor, f => DevedorCommandFaker.Gerar().Generate(RetornaQuantidadeDevedores(random)))
                   .RuleFor(t => t.DataProtocolo, f => f.Date.Recent())
                   .RuleFor(t => t.DataProtesto, f => f.Date.Recent(5))
                   .RuleFor(t => t.DataEmissao, f => f.Date.Recent(-10))
                   .RuleFor(t => t.DataVencimento, f => f.Date.Recent(3))
                   .RuleFor(t => t.DataAcao, f => f.Date.Recent())
                   .RuleFor(t => t.Acao, f => f.PickRandom<EAcao>());

            return titulo;
        }

        private static bool RetornaBool(Random r)
        {
            int valor = r.Next(1, 2);

            if (valor == 1)
                return true;
            else
                return false;
        }

        private static int RetornaQuantidadeDevedores(Random r)
        {
            int qtd = r.Next(1, 5);
            return qtd;
        }
    }
}
