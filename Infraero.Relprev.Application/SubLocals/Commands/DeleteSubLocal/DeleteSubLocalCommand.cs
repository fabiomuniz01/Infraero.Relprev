using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.SubLocals.Commands.DeleteSubLocal
{
    public class DeleteSubLocalCommand : IRequest<bool>
    {
        public long Id { get; set; }

        public class DeleteSubLocalCommandHandler : IRequestHandler<DeleteSubLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteSubLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteSubLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubLocals.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(SubLocal), request.Id);
                }

                _context.SubLocals.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
