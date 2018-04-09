using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Xunit;

namespace BancoUnificadoCore.Test.Command
{
    public class CommandCreateApresentanteTests
    {
        private Faker<CommandCreateApresentante> apresentante;

        [Fact]
        public void ApresentanteValido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            Assert.True(command.Valid);
        }

        [Fact]
        public void ApresentanteCodigoInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            command.CodigoApresentante = "";
            
            Assert.False(command.Invalid);
        }

        [Fact]
        public void ApresentanteCodigoTamanhoInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            int i = 0;

            while (i < 101)
            {
                command.CodigoApresentante += 0;
                i++;
            }

            Assert.False(command.Invalid);
        }

        [Fact]
        public void ApresentanteNomeInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            command.Nome = "";

            Assert.False(command.Invalid);
        }

        [Fact]
        public void ApresentanteNomeTamanhoInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            int i = 0;

            while (i < 101)
            {
                command.Nome += "p21";
                i++;
            }

            Assert.False(command.Invalid);
        }

        [Fact]
        public void ApresentanteSobreNomeInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            command.SobreNome = "";

            Assert.False(command.Invalid);
        }

        [Fact]
        public void ApresentanteSobreNomeTamanhoInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

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
