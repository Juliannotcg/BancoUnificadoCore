using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Enums;
using BancoUnificadoCore.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoUnificadoCore.Test.Entities
{
    [TestClass]
    public class PessoaTest
    {
        [TestMethod]
        public void DeveRetornarPessoaValida()
        {
            var nome = new Nome("Julianno", "Garcia");
            var documento = new Documento(ETipoDocumento.CPF, "08816614650");
            var endereco = new Endereco("QNH 05", "QNH", "Taguatinga", "DF", "72130550");
            var pessoa = new Pessoa(nome, documento, endereco, ETipoEnvolvido.Devedor);

            Assert.IsTrue(pessoa.Valid);
        }
    }
}
