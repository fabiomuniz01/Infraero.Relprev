using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using MediatR;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstruturaDetail
{
    public class UpdateUnidadeInfraestruturaDetailCommand : IRequest
    {
        public UnidadeInfraEstruturaDto UnidadeInfraestruturaDto { get; set; }

        public class UpdateUnidadeInfraestruturaDetailCommandHandler : IRequestHandler<UpdateUnidadeInfraestruturaDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateUnidadeInfraestruturaDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateUnidadeInfraestruturaDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.UnidadeInfraestrutura.FindAsync(request.UnidadeInfraestruturaDto.CodUnidadeInfraestrutura);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.UnidadeInfraestrutura), request.UnidadeInfraestruturaDto.CodUnidadeInfraestrutura);
                }

                entity.Descricao = request.UnidadeInfraestruturaDto.Descricao;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
