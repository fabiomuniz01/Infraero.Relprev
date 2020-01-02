using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.SubLocal.Commands.DeleteSubLocal
{
    public class DeleteSubLocalCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteSubLocalCommandHandler : IRequestHandler<DeleteSubLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteSubLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteSubLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubLocal.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.SubLocal), request.Id);
                }

                _context.SubLocal.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
