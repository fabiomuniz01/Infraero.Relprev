using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.DeleteVinculoUnidadeEmpresa
{
    public class DeleteVinculoUnidadeEmpresaCommand : IRequest<bool>
    {
        public long Id { get; set; }

        public class DeleteVinculoUnidadeEmpresaCommandHandler : IRequestHandler<DeleteVinculoUnidadeEmpresaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteVinculoUnidadeEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteVinculoUnidadeEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.VinculoUnidadeEmpresa.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.VinculoUnidadeEmpresa), request.Id);
                }

                _context.VinculoUnidadeEmpresa.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
