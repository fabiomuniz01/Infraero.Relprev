using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using MediatR;

namespace Infraero.Relprev.Application.Local.Commands.UpdateLocalDetail
{
    public class UpdateLocalDetailCommand : IRequest
    {
        public LocalDto LocalDto { get; set; }

        public class UpdateLocalDetailCommandHandler : IRequestHandler<UpdateLocalDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateLocalDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateLocalDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Locals.FindAsync(request.LocalDto.CodLocal);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Local), request.LocalDto.CodLocal);
                }

                entity.DscLocal = request.LocalDto.DscLocal;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
