using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa
{
    public class DeleteEmpresaCommand : IRequest<bool>
    {
        public long Id { get; set; }

        public class DeleteEmpresaCommandHandler : IRequestHandler<DeleteEmpresaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Empresas.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Empresa), request.Id);
                }

                _context.Empresas.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
