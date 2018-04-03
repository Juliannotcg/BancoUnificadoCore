using BancoUnificadoCore.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.ValueObject
{
    [TestClass]
    public class EnderecoTest
    {
        [TestMethod]
        public void DeveRetornarNotificacaoQuandoLogradouroForVazio()
        {
            var endereco = new Endereco("", "Asa sul", "Plano Piloto", "DF", "72000000");
            Assert.AreEqual(false, endereco.Valid);
            Assert.AreEqual(1, endereco.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoBairroForVazio()
        {
            var endereco = new Endereco("Quadra 910", "", "Plano Piloto", "DF", "72000000");
            Assert.AreEqual(false, endereco.Valid);
            Assert.AreEqual(1, endereco.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoCidadeForVazia()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "", "DF", "72000000");
            Assert.AreEqual(false, endereco.Valid);
            Assert.AreEqual(1, endereco.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoUfForVazia()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "", "72000000");
            Assert.AreEqual(false, endereco.Valid);
            Assert.AreEqual(1, endereco.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoUfForMaiorQueDefinido()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "DFTT", "72000000");
            Assert.AreEqual(false, endereco.Valid);
            Assert.AreEqual(1, endereco.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoCepForMaiorDoQueDefinido()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "DF", "123456789");
            Assert.AreEqual(false, endereco.Valid);
            Assert.AreEqual(1, endereco.Notifications.Count);
        }

        [TestMethod]
        public void NãoDeveRetornarNotificacao()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "DF", "72000000");
            Assert.AreEqual(true, endereco.Valid);
            Assert.AreEqual(0, endereco.Notifications.Count);
        }
    }
}
