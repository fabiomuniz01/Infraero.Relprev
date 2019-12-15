using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Domain.Enums;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocals.Queries.GetSubLocals;

namespace Infraero.Relprev.Application.SubLocals.Commands.UpdateSubLocalDetail
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
                    throw new NotFoundException(nameof(SubLocal), request.SubLocalDto.CodSubLocal);
                }

                entity.DscSubLocal = request.SubLocalDto.DscSubLocal;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
