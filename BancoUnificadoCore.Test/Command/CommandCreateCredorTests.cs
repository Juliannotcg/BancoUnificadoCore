using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Xunit;

namespace BancoUnificadoCore.Test.Command
{
    public class CommandCreateCredorTests
    {
        private Faker<CommandCreateCredor> credor;

        [Fact]
        public void CredorValido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            Assert.True(command.Valid);
        }

        [Fact]
        public void CredorNumeroDocumentoInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            command.NumeroDocumento = "";

            Assert.False(command.Invalid);
        }

        [Fact]
        public void CredorNomeInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            command.Nome = "";

            Assert.False(command.Invalid);
        }

        [Fact]
        public void CredorNomeTamanhoInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            int i = 0;

            while (i < 101)
            {
                command.Nome += "p21";
                i++;
            }

            Assert.False(command.Invalid);
        }

        [Fact]
        public void CredorSobreNomeInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            command.SobreNome = "";

            Assert.False(command.Invalid);
        }

        [Fact]
        public void CredorSobreNomeTamanhoInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            int i = 0;

            while (i < 101)
            {
                command.SobreNome += "p21";
                i++;
            }

            Assert.False(command.Invalid);
        }
    }
}
