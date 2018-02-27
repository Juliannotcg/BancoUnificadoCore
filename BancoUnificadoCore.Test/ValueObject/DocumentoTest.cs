using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.ValueObject
{
    [TestClass]
    public class DocumentoTest
    {
        /// <summary>
        /// Red, Green, Refactor
        /// </summary>
        [TestMethod]
        public void DeveRetornarErrorQuandoCNPJInvalido()
        {
            var doc = new Documento(ETipoDocumento.CNPJ, "123");
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("10566505000171")]
        [DataRow("08883520000100")]
        public void DeveRetornarSucessoQuandoCNPJValido()
        {
            var doc = new Documento(ETipoDocumento.CNPJ, "42016505000194");
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void DeveRetornarErrorQuandoCPFInvalido()
        {
            var doc = new Documento(ETipoDocumento.CPF, "123");
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("54083665610")]
        [DataRow("63626903206")]
        public void DeveRetornarSucessoQuandoCPFValido()
        {
            var doc = new Documento(ETipoDocumento.CPF, "08816614650");
            Assert.IsTrue(doc.Valid);
        }
    }
}
