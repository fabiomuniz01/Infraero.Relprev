using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.SubAssunto.Commands.DeleteSubAssunto
{
    public class DeleteSubAssuntoCommand : IRequest<bool>
    {
        public long Id { get; set; }

        public class DeleteSubAssuntoCommandHandler : IRequestHandler<DeleteSubAssuntoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteSubAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteSubAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubAssuntos.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(SubAssunto), request.Id);
                }

                _context.SubAssuntos.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
