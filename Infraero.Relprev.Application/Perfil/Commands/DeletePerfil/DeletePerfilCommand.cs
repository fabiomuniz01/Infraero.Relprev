using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Perfil.Commands.DeletePerfil
{
    public class DeletePerfilCommand : IRequest<bool>
    {
        public string CodPerfil { get; set; }

        public class DeletePerfilCommandHandler : IRequestHandler<DeletePerfilCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeletePerfilCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeletePerfilCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Perfil.FindAsync(request.CodPerfil);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Perfil), request.CodPerfil);
                }

                _context.Perfil.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
