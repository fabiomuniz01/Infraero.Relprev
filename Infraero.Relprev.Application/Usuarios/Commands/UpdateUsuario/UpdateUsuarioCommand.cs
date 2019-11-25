using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario
{
    public partial class UpdateUsuarioCommand : IRequest
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateUsuarioCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Usuarios.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Usuario), request.Id);
                }

                entity.Title = request.Title;
                entity.Done = request.Done;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
