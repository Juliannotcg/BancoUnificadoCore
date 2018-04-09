using BancoUnificadoCore.Domain.ValueObjects;
using Xunit;

namespace BancoUnificadoCore.Test.ValueObject
{
    public class NomeTests
    {
        [Fact]
        public void DeveRetornarNotificacaoQuandoPrimeiroNomeVazio()
        {
            var nome = new Nome("", "Garcia");
            Assert.Equal(false, nome.Valid);
            Assert.Equal(1, nome.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoPrimeiroNomePequeno()
        {
            var nome = new Nome("as", "Garcia");
            Assert.Equal(false, nome.Valid);
            Assert.Equal(1, nome.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoSobreNomeVazio()
        {
            var nome = new Nome("Julianno", "");
            Assert.Equal(false, nome.Valid);
            Assert.Equal(1, nome.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoSobreNomePequeno()
        {
            var nome = new Nome("Julianno", "as");
            Assert.Equal(false, nome.Valid);
            Assert.Equal(1, nome.Notifications.Count);
        }
    }
}