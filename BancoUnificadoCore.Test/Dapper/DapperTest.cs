using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Infrastructure.Context;
using BancoUnificadoCore.Infrastructure.Repository.Dapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoUnificadoCore.Test.Dapper
{
    [TestClass]
    public class DapperTest
    {
        [TestMethod]
        public void DeveRetornarUmApresentanteQueExiste()
        {
            var ctx = new ContextDapper();
            var repo = new ApresentanteRepositoryDapper(ctx);
            Assert.AreEqual(repo.CheckApresentante("08816614650"), true);
        }

        [TestMethod]
        public void DeveRetornarUmApresentanteQueNaoExiste()
        {
            var ctx = new ContextDapper();
            var repo = new ApresentanteRepositoryDapper(ctx);
            Assert.AreEqual(repo.CheckApresentante("00000000000000"), false);
        }

        [TestMethod]
        public void SalvarUmApresentanteValido()
        {
            var ctx = new ContextDapper();
            var repo = new ApresentanteRepositoryDapper(ctx);

            var nome = new Nome("P21", "Sistemas");
            var documento = new Documento(ETipoDocumento.CPF, "08816614650");
            var endereco = new Endereco("QNH 05", "QNH", "72130550", "Brasilia", "DF");
            var apresentante = new Apresentante("255", nome, documento, endereco);
            repo.Save(apresentante);

            Assert.IsTrue(true);
        }
    }
}
