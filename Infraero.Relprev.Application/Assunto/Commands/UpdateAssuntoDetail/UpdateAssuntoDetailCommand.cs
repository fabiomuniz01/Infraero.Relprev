using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Assunto.Commands.UpdateAssuntoDetail
{
    public class UpdateAssuntoDetailCommand : IRequest
    {
        public AssuntoDto AssuntoDto { get; set; }

        public class UpdateAssuntoDetailCommandHandler : IRequestHandler<UpdateAssuntoDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateAssuntoDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateAssuntoDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Assunto.FindAsync(request.AssuntoDto.CodAssunto);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.AssuntoDto.CodAssunto);
                }

                entity.DscAssunto = request.AssuntoDto.DscAssunto;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
