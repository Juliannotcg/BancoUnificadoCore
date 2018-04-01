using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.ValueObject
{
    [TestClass]
    public class DocumentoTest
    {
        private Documento DocumentoCPFValido;
        private Documento DocumentoCPFInvalido;
        private Documento DocumentoCNPJValido;
        private Documento DocumentoCNPJInvalido;

        public DocumentoTest()
        {
            DocumentoCPFValido = new Documento(ETipoDocumento.CPF, "28659170377");
            DocumentoCPFInvalido = new Documento(ETipoDocumento.CPF, "12345678910");
            DocumentoCNPJValido = new Documento(ETipoDocumento.CNPJ, "28659170377");
            DocumentoCNPJInvalido = new Documento(ETipoDocumento.CNPJ, "12345678910");
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoCPFnaoValido()
        {
            Assert.AreEqual(false, DocumentoCPFInvalido.Valid);
            Assert.AreEqual(1, DocumentoCPFInvalido.Notifications.Count);
        }

        [TestMethod]
        public void NaoDeveRetornarNotificacaoQuandoCPFValido()
        {
            Assert.AreEqual(true, DocumentoCPFValido.Valid);
            Assert.AreEqual(0, DocumentoCPFValido.Notifications.Count);
        }

        [TestMethod]
        public void DeveRetornarNotificacaoQuandoCNPJnaoValido()
        {
            Assert.AreEqual(false, DocumentoCNPJInvalido.Valid);
            Assert.AreEqual(1, DocumentoCPFInvalido.Notifications.Count);
        }

        [TestMethod]
        public void NaoDeveRetornarNotificacaoQuandoCNPJValido()
        {
            Assert.AreEqual(true, DocumentoCNPJValido.Valid);
            Assert.AreEqual(0, DocumentoCNPJValido.Notifications.Count);
        }
    }
}
