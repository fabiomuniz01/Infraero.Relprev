using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.ResponsavelTecnico.Commands.DeleteResponsavelTecnico
{
    public class DeleteResponsavelTecnicoCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeleteResponsavelTecnicoCommandHandler : IRequestHandler<DeleteResponsavelTecnicoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public DeleteResponsavelTecnicoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteResponsavelTecnicoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.ResponsavelTecnico.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(ResponsavelTecnico), request.Id);
                }

                _context.ResponsavelTecnico.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
