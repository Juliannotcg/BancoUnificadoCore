using BancoUnificadoCore.Domain.Commands.Titulo;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Xunit;

namespace BancoUnificadoCore.Test.Command
{
    public class CommandCreateTituloTests
    {
        private Faker<CommandCreateTitulo> titulo;

        [Fact]
        public void TituloValido()
        {
            titulo = TituloCommandFaker.Gerar();

            var command = titulo.Generate();

            Assert.True(command.Valid);
        }

        [Fact]
        public void tituloSobreNomeInvalido()
        {
            titulo = TituloCommandFaker.Gerar();

            var command = titulo.Generate();

            command.Protocolo = "";

            Assert.False(command.Invalid);
        }

        [Fact]
        public void tituloSobreNomeTamanhoInvalido()
        {
            titulo = TituloCommandFaker.Gerar();

            var command = titulo.Generate();

            int i = 0;

            while (i < 11)
            {
                command.Protocolo += "00";
                i++;
            }

            Assert.False(command.Invalid);
        }
    }
}
