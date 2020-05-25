using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.RelatoArquivo.Commands.DeleteRelatoArquivo
{
    public class DeleteRelatoArquivoCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteRelatoArquivoCommandHandler : IRequestHandler<DeleteRelatoArquivoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteRelatoArquivoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteRelatoArquivoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.RelatoArquivo.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(RelatoArquivo), request.Id);
                }

                _context.RelatoArquivo.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
