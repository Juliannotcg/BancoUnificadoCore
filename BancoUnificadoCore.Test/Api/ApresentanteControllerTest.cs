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
    public class ApresentanteControllerTest : BaseWebTest
    {
        private Faker<CommandCreateApresentante> apresentante;

        [Fact]
        public async Task ReturnCreated()
        {
            // Arrange
            apresentante = ApresentanteCommandFaker.Gerar();

            var apresentanteGerado = apresentante.Generate();

            // Act
            StringContent content = new StringContent(JsonConvert.SerializeObject(apresentanteGerado), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("v1/apresentante", content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

    }
}
