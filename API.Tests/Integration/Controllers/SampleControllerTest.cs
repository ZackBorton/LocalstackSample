using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace API.Tests.Integration.Controllers
{
    public class SampleControllerTest : IClassFixture<WebApplicationFactory<API.Startup>>
    {
        private readonly WebApplicationFactory<API.Startup> _factory;

        public SampleControllerTest(WebApplicationFactory<API.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/Sample?api-version=2")]
        [InlineData("/api/Sample?api-version=1")]
        public async Task Get_EndpointsReturnSuccess(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}