using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Domain.Enums;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssuntos.Queries.GetSubAssuntos;

namespace Infraero.Relprev.Application.SubAssuntos.Commands.UpdateSubAssuntoDetail
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
                    throw new NotFoundException(nameof(SubAssunto), request.SubAssuntoDto.CodSubAssunto);
                }

                entity.DscSubAssunto = request.SubAssuntoDto.DscSubAssunto;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
