using BancoUnificadoCore.Domain.Commands.Titulo;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.Command
{
    [TestClass]
    public class CommandCreateTituloTests
    {
        private Faker<CommandCreateTitulo> titulo;

        [TestMethod]
        public void TituloValido()
        {
            titulo = TituloCommandFaker.Gerar();

            var command = titulo.Generate();

            Assert.IsTrue(command.Valid);
        }

        [TestMethod]
        public void tituloSobreNomeInvalido()
        {
            titulo = TituloCommandFaker.Gerar();

            var command = titulo.Generate();

            command.Protocolo = "";

            Assert.IsFalse(command.Invalid);
        }

        [TestMethod]
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

            Assert.IsFalse(command.Invalid);
        }
    }
}
