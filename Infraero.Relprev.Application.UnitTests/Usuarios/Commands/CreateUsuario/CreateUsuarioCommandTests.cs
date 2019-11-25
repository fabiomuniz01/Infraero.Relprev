using Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario;
using Infraero.Relprev.Application.UnitTests.Common;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Infraero.Relprev.Application.UnitTests.Usuarios.Commands.CreateUsuario
{
    public class CreateUsuarioCommandTests : CommandTestBase
    {
        [Fact]
        public async Task Handle_ShouldPersistUsuario()
        {
            var command = new CreateUsuarioCommand
            {
                Title = "Do yet another thing."
            };

            var handler = new CreateUsuarioCommand.CreateUsuarioCommandHandler(Context);

            var result = await handler.Handle(command, CancellationToken.None);

            var entity = Context.Usuarios.Find(result);

            entity.ShouldNotBeNull();
            entity.Title.ShouldBe(command.Title);
        }
    }
}
