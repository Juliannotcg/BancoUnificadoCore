using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.Command
{
    [TestClass]
    public class CommandCreateApresentanteTests
    {
        private Faker<CommandCreateApresentante> apresentante;

        [TestMethod]
        public void ApresentanteValido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            Assert.IsTrue(command.Valid);
        }

        [TestMethod]
        public void ApresentanteCodigoInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            command.CodigoApresentante = "";
            
            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
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

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
        public void ApresentanteNomeInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            command.Nome = "";

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
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

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
        public void ApresentanteSobreNomeInvalido()
        {
            apresentante = ApresentanteCommandFaker.Gerar();

            var command = apresentante.Generate();

            command.SobreNome = "";

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
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

            Assert.IsFalse(command.Invalid);
        }
    }
}
