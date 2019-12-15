using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Assuntos.Commands.DeleteAssunto
{
    public class DeleteUnidadeInfraEstruturaCommand : IRequest
    {
        public long Id { get; set; }

        public class DeleteAssuntoCommandHandler : IRequestHandler<DeleteUnidadeInfraEstruturaCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteUnidadeInfraEstruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Assuntos.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.Id);
                }

                _context.Assuntos.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
