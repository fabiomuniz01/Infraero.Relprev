using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Arquivo.Commands.DeleteArquivo
{
    public class DeleteArquivoCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteArquivoCommandHandler : IRequestHandler<DeleteArquivoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteArquivoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteArquivoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Arquivo.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Arquivo), request.Id);
                }

                _context.Arquivo.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
