using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Test.Helpers.Fakers;
using Bogus;
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
    public class ApresentanteControllerTest : BaseWebTest
    {
        private Faker<CommandCreateApresentante> apresentante;

        [TestMethod]
        public async Task ReturnCreated()
        {
            // Arrange
            apresentante = ApresentanteCommandFaker.Gerar();

            var apresentanteGerado = apresentante.Generate();

            // Act
            StringContent content = new StringContent(JsonConvert.SerializeObject(apresentanteGerado), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/orgaoEmissor", content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            Assert.IsTrue(response.StatusCode == HttpStatusCode.OK);
        }

    }
}
