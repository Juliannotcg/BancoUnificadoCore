using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.Command
{
    [TestClass]
    public class CommandCargaDiariaTests
    {
        private Faker<CommandCreateCargaDiaria> cargaDiaria;

        [TestMethod]
        public void CargaDiariaValida()
        {
            cargaDiaria = CargaDiariaCommandFaker.Gerar();

            var command = cargaDiaria.Generate();

            Assert.IsTrue(command.Valid);
        }

        [TestMethod]
        public void CargaDiariaInvalida()
        {
            var command = new CommandCreateCargaDiaria();

            Assert.IsTrue(command.Invalid);
        }
    }
}
