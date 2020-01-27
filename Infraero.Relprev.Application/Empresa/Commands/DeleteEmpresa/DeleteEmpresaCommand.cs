using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa
{
    public class DeleteEmpresaCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteEmpresaCommandHandler : IRequestHandler<DeleteEmpresaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Empresa.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Empresa), request.Id);
                }

                _context.Empresa.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
