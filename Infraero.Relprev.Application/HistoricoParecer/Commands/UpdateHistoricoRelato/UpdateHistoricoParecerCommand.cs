using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.HistoricoParecer.Commands.UpdateHistoricoParecer
{
    public partial class UpdateHistoricoParecerCommand : IRequest<bool>
    {

        public class UpdateHistoricoParecerCommandHandler : IRequestHandler<UpdateHistoricoParecerCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateHistoricoParecerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateHistoricoParecerCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.HistoricoParecer.FindAsync(request.CodHistoricoParecer);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.HistoricoParecer), request.CodHistoricoParecer);
                }

                

                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string AlteradoPor { get; set; }
        public int CodHistoricoParecer { get; set; }
    }
}
