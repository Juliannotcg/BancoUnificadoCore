using BancoUnificadoCore.Test.Helpers.Fakers;
using Civil21.Obito.Tests.Helpers;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BancoUnificadoCore.Test.Api
{
    public class DevedorControllerTests : BaseWebTest
    {
        //TO DO: Implementar o command do devedor
        //private Faker<CommandCreateDevedor> devedor;

        [Fact]
        public async Task ReturnCreated()
        {
            // Arrange
            var devedor = DevedorCommandFaker.Gerar();

            var command = devedor.Generate();

            // Act
            StringContent content = new StringContent(JsonConvert.SerializeObject(command), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("v1/devedor", content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }
    }
}
