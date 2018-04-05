using BancoUnificadoCore.Domain.Commands;
using Bogus;

namespace BancoUnificadoCore.Test.Helpers.Fakers
{
    public static class CargaDiariaCommandFaker
    {
        public static Faker<CommandCreateCargaDiaria> Gerar()
        {
            Faker<CommandCreateCargaDiaria> cargaDiaria = new Faker<CommandCreateCargaDiaria>()
                   .RuleFor(c => c.Titulo, f => TituloCommandFaker.Gerar());

            return cargaDiaria;
        }
    }
}
