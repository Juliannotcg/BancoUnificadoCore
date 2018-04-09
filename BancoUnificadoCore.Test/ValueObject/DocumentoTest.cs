using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using Xunit;

namespace BancoUnificadoCore.Test.ValueObject
{
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

        [Fact]
        public void DeveRetornarNotificacaoQuandoCPFnaoValido()
        {
            Assert.Equal(false, DocumentoCPFInvalido.Valid);
            Assert.Equal(1, DocumentoCPFInvalido.Notifications.Count);
        }

        [Fact]
        public void NaoDeveRetornarNotificacaoQuandoCPFValido()
        {
            Assert.Equal(true, DocumentoCPFValido.Valid);
            Assert.Equal(0, DocumentoCPFValido.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoCNPJnaoValido()
        {
            Assert.Equal(false, DocumentoCNPJInvalido.Valid);
            Assert.Equal(1, DocumentoCPFInvalido.Notifications.Count);
        }

        [Fact]
        public void NaoDeveRetornarNotificacaoQuandoCNPJValido()
        {
            Assert.Equal(true, DocumentoCNPJValido.Valid);
            Assert.Equal(0, DocumentoCNPJValido.Notifications.Count);
        }
    }
}
