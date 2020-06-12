using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Relato.Commands.CancelRelato
{
    public partial class CancelRelatoCommand : IRequest<long>
    {

        public class CancelRelatoCommandHandler : IRequestHandler<CancelRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CancelRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CancelRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Relato.FindAsync(request.CodRelato);

                entity.DscMotivoRelato = request.DscMotivoCancelamento;
                entity.FlgStatusRelato = request.FlgStatusRelato;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                await _context.SaveChangesAsync(cancellationToken);

                var entityHistorico = await _context.HistoricoRelato
                    .Where(x => x.CodRelato == entity.CodRelato)
                    .FirstOrDefaultAsync(cancellationToken);

                entityHistorico.DscUltimaOcorrencia = entity.DscOcorrenciaRelator;
                //Rn0034 - Ocorrência classificada 
                entityHistorico.DscCancelamento = request.DscCancelamento;
                entityHistorico.AlteradoPor = request.AlteradoPor;
                entityHistorico.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodRelato;
            }
        }

        public string DscMotivoCancelamento { get; set; }
        public string AlteradoPor { get; set; }
        public int FlgStatusRelato { get; set; }
        public int CodRelato { get; set; }
        public string DscCancelamento { get; set; }
    }
}
