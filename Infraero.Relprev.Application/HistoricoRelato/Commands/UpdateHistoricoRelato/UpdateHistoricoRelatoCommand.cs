using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.HistoricoRelato.Commands.UpdateHistoricoRelato
{
    public partial class UpdateHistoricoRelatoCommand : IRequest<bool>
    {

        public class UpdateHistoricoRelatoCommandHandler : IRequestHandler<UpdateHistoricoRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateHistoricoRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateHistoricoRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.HistoricoRelato.FindAsync(request.CodHistoricoRelato);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.HistoricoRelato), request.CodHistoricoRelato);
                }

                

                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string TextoMotivoCancelamento { get; set; }
        public int TempoNotificacaoParaResponder { get; set; }
        public int DevolvidoParaComplemento { get; set; }
        public int ParecerTecnico { get; set; }
        public string AlteradoPor { get; set; }
        public int CodHistoricoRelato { get; set; }
    }
}
