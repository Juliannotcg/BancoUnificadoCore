using BancoUnificadoCore.Domain.Commands.Credor;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.Command
{
    [TestClass]
    public class CommandCreateCredorTests
    {
        private Faker<CommandCreateCredor> credor;

        [TestMethod]
        public void CredorValido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            Assert.IsTrue(command.Valid);
        }

        [TestMethod]
        public void CredorNumeroDocumentoInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            command.NumeroDocumento = "";

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
        public void CredorNomeInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            command.Nome = "";

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
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

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
        public void CredorSobreNomeInvalido()
        {
            credor = CredorCommandFaker.Gerar();

            var command = credor.Generate();

            command.SobreNome = "";

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
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

            Assert.IsFalse(command.Invalid);
        }
    }
}
