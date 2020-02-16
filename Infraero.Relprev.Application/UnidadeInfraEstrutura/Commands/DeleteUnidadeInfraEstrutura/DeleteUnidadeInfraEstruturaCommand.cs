using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.DeleteUnidadeInfraEstrutura
{
    public class DeleteUnidadeInfraEstruturaCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteUnidadeInfraestruturaCommandHandler : IRequestHandler<DeleteUnidadeInfraEstruturaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteUnidadeInfraestruturaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteUnidadeInfraEstruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.UnidadeInfraestrutura.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(UnidadeInfraestrutura), request.Id);
                }

                _context.UnidadeInfraestrutura.Remove(entity);

                var result = await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
