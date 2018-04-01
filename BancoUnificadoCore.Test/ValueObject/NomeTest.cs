using BancoUnificadoCore.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.ValueObject
{
    [TestClass]
    public class NomeTests
    {
        [TestMethod]
        public void DeveRetornarNotificacaoQuandoPrimeiroNomeVazio()
        {
            var nome = new Nome("", "Garcia");
            Assert.AreEqual(false, nome.Valid);
            Assert.AreEqual(1, nome.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoPrimeiroNomePequeno()
        {
            var nome = new Nome("as", "Garcia");
            Assert.AreEqual(false, nome.Valid);
            Assert.AreEqual(1, nome.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoSobreNomeVazio()
        {
            var nome = new Nome("Julianno", "");
            Assert.AreEqual(false, nome.Valid);
            Assert.AreEqual(1, nome.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoSobreNomePequeno()
        {
            var nome = new Nome("Julianno", "as");
            Assert.AreEqual(false, nome.Valid);
            Assert.AreEqual(1, nome.Notifications.Count);
        }
    }
}