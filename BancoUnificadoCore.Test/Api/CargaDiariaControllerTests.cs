using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
using Civil21.Obito.Tests.Helpers;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BancoUnificadoCore.Test.Api
{
    public class CargaDiariaControllerTests : BaseWebTest
    {
        private Faker<CommandCreateCargaDiaria> cargaDiaria;

        [Fact]
        public async Task ReturnCreated()
        {
            // Arrange
            cargaDiaria = CargaDiariaCommandFaker.Gerar();

            var carga = cargaDiaria.Generate();

            // Act
            StringContent content = new StringContent(JsonConvert.SerializeObject(carga), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("v1/cargaDiaria", content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

    }
}
