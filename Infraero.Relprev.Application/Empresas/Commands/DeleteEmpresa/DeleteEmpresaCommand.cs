using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Empresas.Commands.DeleteEmpresa
{
    public class DeleteEmpresaCommand : IRequest
    {
        public long Id { get; set; }

        public class DeleteEmpresaCommandHandler : IRequestHandler<DeleteEmpresaCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Empresas.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Empresa), request.Id);
                }

                _context.Empresas.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
