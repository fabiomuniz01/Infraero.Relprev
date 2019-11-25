using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Usuarios.Commands.DeleteUsuario
{
    public class DeleteUsuarioCommand : IRequest
    {
        public long Id { get; set; }

        public class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteUsuarioCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Usuarios.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Usuario), request.Id);
                }

                _context.Usuarios.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
