using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Assunto.Commands.DeleteAssunto
{
    public class DeleteAssuntoCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteAssuntoCommandHandler : IRequestHandler<DeleteAssuntoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Assunto.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.Id);
                }

                _context.Assunto.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
