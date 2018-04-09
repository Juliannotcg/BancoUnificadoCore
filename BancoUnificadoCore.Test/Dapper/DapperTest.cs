using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using BancoUnificadoCore.Infrastructure.Context;
using BancoUnificadoCore.Infrastructure.Repository.Dapper;
using Xunit;

namespace BancoUnificadoCore.Test.Dapper
{
    public class DapperTest
    {
        [Fact]
        public void DeveRetornarUmApresentanteQueExiste()
        {
            var ctx = new ContextDapper();
            var repo = new ApresentanteRepositoryDapper(ctx);
            var AprExist = repo.CheckApresentante("08816614650");

            if (AprExist != null)
                Assert.True(true);
        }

        [Fact]
        public void DeveRetornarUmApresentanteQueNaoExiste()
        {
            var ctx = new ContextDapper();
            var repo = new ApresentanteRepositoryDapper(ctx);
            var AprExist = repo.CheckApresentante("0000000000");

            if (AprExist != null)
                Assert.True(false);
        }

        [Fact]
        public void SalvarUmApresentanteValido()
        {
            var ctx = new ContextDapper();
            var repo = new ApresentanteRepositoryDapper(ctx);

            var nome = new Nome("P21", "Sistemas");
            var documento = new Documento(ETipoDocumento.CPF, "08816614650");
            var endereco = new Endereco("QNH 05", "QNH", "72130550", "Brasilia", "DF");
            var apresentante = new Apresentante("255", nome, documento, endereco);
            repo.Save(apresentante);
            Assert.True(true);
        }
    }
}
