using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Usuario.Commands.DeleteUsuario
{
    public class DeleteUsuarioCommand : IRequest<bool>
    {
        public long Id { get; set; }

        public class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteUsuarioCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Usuarios.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Usuario), request.Id);
                }

                _context.Usuarios.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
