using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Usuarios.Commands.DeleteUsuario;
using Infraero.Relprev.Application.UnitTests.Common;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Infraero.Relprev.Application.UnitTests.Usuarios.Commands.DeleteUsuario
{
    public class DeleteUsuarioCommandTests : CommandTestBase
    {
        [Fact]
        public async Task Handle_GivenValidId_ShouldRemovePersistedUsuario()
        {
            var command = new DeleteUsuarioCommand
            {
                Id = 1
            };

            var handler = new DeleteUsuarioCommand.DeleteUsuarioCommandHandler(Context);

            await handler.Handle(command, CancellationToken.None);

            var entity = Context.Usuarios.Find(command.Id);

            entity.ShouldBeNull();
        }

        [Fact]
        public void Handle_GivenInvalidId_ThrowsException()
        {
            var command = new DeleteUsuarioCommand
            {
                Id = 99
            };

            var handler = new DeleteUsuarioCommand.DeleteUsuarioCommandHandler(Context);

            Should.ThrowAsync<NotFoundException>(() => 
                handler.Handle(command, CancellationToken.None));
        }
    }
}
