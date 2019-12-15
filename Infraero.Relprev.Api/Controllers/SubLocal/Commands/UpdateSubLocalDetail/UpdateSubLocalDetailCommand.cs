using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Api.Controllers.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Api.Controllers.SubLocal.Commands.UpdateSubLocalDetail
{
    public class UpdateSubLocalDetailCommand : IRequest
    {
        public SubLocalDto SubLocalDto { get; set; }

        public class UpdateSubLocalDetailCommandHandler : IRequestHandler<UpdateSubLocalDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateSubLocalDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateSubLocalDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubLocals.FindAsync(request.SubLocalDto.CodSubLocal);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.SubLocal), request.SubLocalDto.CodSubLocal);
                }

                entity.DscSubLocal = request.SubLocalDto.DscSubLocal;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
