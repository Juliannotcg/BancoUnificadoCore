using BancoUnificadoCore.Domain.ValueObjects;
using Xunit;

namespace BancoUnificadoCore.Test.ValueObject
{
    public class EnderecoTest
    {
        [Fact]
        public void DeveRetornarNotificacaoQuandoLogradouroForVazio()
        {
            var endereco = new Endereco("", "Asa sul", "Plano Piloto", "DF", "72000000");
            Assert.Equal(false, endereco.Valid);
            Assert.Equal(1, endereco.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoBairroForVazio()
        {
            var endereco = new Endereco("Quadra 910", "", "Plano Piloto", "DF", "72000000");
            Assert.Equal(false, endereco.Valid);
            Assert.Equal(1, endereco.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoCidadeForVazia()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "", "DF", "72000000");
            Assert.Equal(false, endereco.Valid);
            Assert.Equal(1, endereco.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoUfForVazia()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "", "72000000");
            Assert.Equal(false, endereco.Valid);
            Assert.Equal(1, endereco.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoUfForMaiorQueDefinido()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "DFTT", "72000000");
            Assert.Equal(false, endereco.Valid);
            Assert.Equal(1, endereco.Notifications.Count);
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoCepForMaiorDoQueDefinido()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "DF", "123456789");
            Assert.Equal(false, endereco.Valid);
            Assert.Equal(1, endereco.Notifications.Count);
        }

        [Fact]
        public void NãoDeveRetornarNotificacao()
        {
            var endereco = new Endereco("Quadra 910", "Asa Sul", "Plano piloto", "DF", "72000000");
            Assert.Equal(true, endereco.Valid);
            Assert.Equal(0, endereco.Notifications.Count);
        }
    }
}
