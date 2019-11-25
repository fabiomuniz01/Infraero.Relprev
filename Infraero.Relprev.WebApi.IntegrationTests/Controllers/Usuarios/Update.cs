using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario;
using System.Threading.Tasks;
using Xunit;

namespace Infraero.Relprev.WebApi.IntegrationTests.Controllers.Usuarios
{
    public class Update : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public Update(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GivenValidUpdateUsuarioCommand_ReturnsSuccessCode()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var command = new UpdateUsuarioCommand
            { 
                Id = 1, 
                Title = "Do this thing.",
                Done = true
            };

            var content = IntegrationTestHelper.GetRequestContent(command);

            var response = await client.PutAsync($"/api/Usuarios/{command.Id}", content);

            response.EnsureSuccessStatusCode();
        }
    }
}
