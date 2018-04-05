using BancoUnificadoCore.Test.Helpers.Fakers;
using Civil21.Obito.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BancoUnificadoCore.Test.Api
{
    [TestClass]
    public class DevedorControllerTests : BaseWebTest
    {
        //TO DO: Implementar o command do devedor
        //private Faker<CommandCreateDevedor> devedor;

        [TestMethod]
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
            Assert.IsTrue(response.StatusCode == HttpStatusCode.OK);
        }
    }
}
