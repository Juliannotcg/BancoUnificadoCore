using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Xunit;

namespace BancoUnificadoCore.Test.Command
{
    public class CommandCargaDiariaTests
    {
        private Faker<CommandCreateCargaDiaria> cargaDiaria;

        [Fact]
        public void CargaDiariaValida()
        {
            cargaDiaria = CargaDiariaCommandFaker.Gerar();

            var command = cargaDiaria.Generate();

            Assert.True(command.Valid);
        }

        [Fact]
        public void CargaDiariaInvalida()
        {
            var command = new CommandCreateCargaDiaria();

            Assert.True(command.Invalid);
        }
    }
}
