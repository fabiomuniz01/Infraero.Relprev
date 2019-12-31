using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Local.Commands.DeleteLocal
{
    public class DeleteLocalCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteLocalCommandHandler : IRequestHandler<DeleteLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Local.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Local), request.Id);
                }

                _context.Local.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
