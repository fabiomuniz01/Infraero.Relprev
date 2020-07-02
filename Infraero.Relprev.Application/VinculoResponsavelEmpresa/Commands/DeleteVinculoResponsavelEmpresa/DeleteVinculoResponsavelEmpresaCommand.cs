using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Commands.DeleteVinculoResponsavelEmpresa
{
    public class DeleteVinculoResponsavelEmpresaCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteVinculoResponsavelEmpresaCommandHandler : IRequestHandler<DeleteVinculoResponsavelEmpresaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteVinculoResponsavelEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteVinculoResponsavelEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.VinculoResponsavelEmpresa.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.VinculoResponsavelEmpresa), request.Id);
                }

                _context.VinculoResponsavelEmpresa.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
