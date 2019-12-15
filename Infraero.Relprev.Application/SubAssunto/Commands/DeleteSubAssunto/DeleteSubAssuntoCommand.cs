using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.SubAssuntos.Commands.DeleteSubAssunto
{
    public class DeleteUnidadeInfraestruturaCommand : IRequest
    {
        public long Id { get; set; }

        public class DeleteSubAssuntoCommandHandler : IRequestHandler<DeleteUnidadeInfraestruturaCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteSubAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteUnidadeInfraestruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubAssuntos.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(SubAssunto), request.Id);
                }

                _context.SubAssuntos.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
