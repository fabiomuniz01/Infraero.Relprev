using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.ParecerArquivo.Commands.DeleteParecerArquivo
{
    public class DeleteParecerArquivoCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteParecerArquivoCommandHandler : IRequestHandler<DeleteParecerArquivoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteParecerArquivoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteParecerArquivoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.ParecerArquivo.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(ParecerArquivo), request.Id);
                }

                _context.ParecerArquivo.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
