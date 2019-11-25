using Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario;
using Shouldly;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Infraero.Relprev.WebApi.IntegrationTests.Controllers.Usuarios
{
    public class Create : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public Create(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GivenValidCreateUsuarioCommand_ReturnsSuccessCode()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var command = new CreateUsuarioCommand
            {
                Title = "Do yet another thing."
            };

            var content = IntegrationTestHelper.GetRequestContent(command);

            var response = await client.PostAsync($"/api/Usuarios", content);

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GivenInvalidCreateUsuarioCommand_ReturnsBadRequest()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var command = new CreateUsuarioCommand
            {
                Title = "This description of this thing will exceed the maximum length. This description of this thing will exceed the maximum length. This description of this thing will exceed the maximum length. This description of this thing will exceed the maximum length."
            };

            var content = IntegrationTestHelper.GetRequestContent(command);

            var response = await client.PostAsync($"/api/Usuarios", content);

            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }
    }
}
