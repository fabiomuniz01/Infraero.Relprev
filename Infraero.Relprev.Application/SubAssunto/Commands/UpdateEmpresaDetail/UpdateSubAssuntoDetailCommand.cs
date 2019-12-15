using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using MediatR;

namespace Infraero.Relprev.Application.SubAssunto.Commands.UpdateEmpresaDetail
{
    public class UpdateSubAssuntoDetailCommand : IRequest
    {
        public SubAssuntoDto SubAssuntoDto { get; set; }

        public class UpdateSubAssuntoDetailCommandHandler : IRequestHandler<UpdateSubAssuntoDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateSubAssuntoDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateSubAssuntoDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubAssuntos.FindAsync(request.SubAssuntoDto.CodSubAssunto);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.SubAssunto), request.SubAssuntoDto.CodSubAssunto);
                }

                entity.DscSubAssunto = request.SubAssuntoDto.DscSubAssunto;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
