using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.DeleteUnidadeInfraEstrutura
{
    public class DeleteUnidadeInfraEstruturaCommand : IRequest
    {
        public int Id { get; set; }

        public class DeleteUnidadeInfraestruturaCommandHandler : IRequestHandler<DeleteUnidadeInfraEstruturaCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteUnidadeInfraestruturaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteUnidadeInfraEstruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.UnidadeInfraestrutura.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(UnidadeInfraestrutura), request.Id);
                }

                _context.UnidadeInfraestrutura.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
