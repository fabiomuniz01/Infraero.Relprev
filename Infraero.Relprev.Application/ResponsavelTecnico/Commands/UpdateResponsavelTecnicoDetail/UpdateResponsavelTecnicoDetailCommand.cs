using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using MediatR;

namespace Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnicoDetail
{
    public class UpdateResponsavelTecnicoDetailCommand : IRequest
    {
        public ResponsavelTecnicoDto ResponsavelTecnicoDto { get; set; }

        public class UpdateResponsavelTecnicoDetailCommandHandler : IRequestHandler<UpdateResponsavelTecnicoDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateResponsavelTecnicoDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateResponsavelTecnicoDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.ResponsavelTecnico.FindAsync(request.ResponsavelTecnicoDto.CodResponsavelTecnico);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(ResponsavelTecnico), request.ResponsavelTecnicoDto.CodResponsavelTecnico);
                }

                entity.NomResponsavelTecnico = request.ResponsavelTecnicoDto.NomResponsavelTecnico;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
