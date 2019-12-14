using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario;
using Infraero.Relprev.Application.UnitTests.Common;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Infraero.Relprev.Application.UnitTests.Usuarios.Commands.UpdateUsuario
{
    public class UpdateUsuarioCommandTests : CommandTestBase
    {
        [Fact]
        public async Task Handle_GivenValidId_ShouldUpdatePersistedUsuario()
        {
            var command = new UpdateUsuarioCommand
            {
                Id = 1,
                Title = "This thing is also done.",
                Done = true
            };

            var handler = new UpdateUsuarioCommand.UpdateUsuarioCommandHandler(Context);

            await handler.Handle(command, CancellationToken.None);

            var entity = Context.Usuarios.Find(command.Id);

            entity.ShouldNotBeNull();
            entity.Title.ShouldBe(command.Title);
            entity.Done.ShouldBeTrue();
        }

        [Fact]
        public void Handle_GivenInvalidId_ThrowsException()
        {
            var command = new UpdateUsuarioCommand
            {
                Id = 99,
                Title = "This item doesn't exist.",
                Done = false
            };

            var sut = new UpdateUsuarioCommand.UpdateUsuarioCommandHandler(Context);

            Should.ThrowAsync<NotFoundException>(() => 
                sut.Handle(command, CancellationToken.None));
        }
    }
}