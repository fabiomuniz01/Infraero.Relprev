using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Relato.Commands.FinalizeRelato
{
    public partial class FinalizeRelatoCommand : IRequest<long>
    {

        public class FinalizeRelatoCommandHandler : IRequestHandler<FinalizeRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public FinalizeRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(FinalizeRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Relato.FindAsync(request.CodRelato);

                entity.DscAcoesCorretivasRecomendadas = request.AcoesCorretivasRecomendadas;
                entity.FlgStatusRelato = request.FlgStatusRelato;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                await _context.SaveChangesAsync(cancellationToken);

                var entityHistorico = await _context.HistoricoRelato
                    .Where(x => x.CodRelato == entity.CodRelato)
                    .FirstOrDefaultAsync(cancellationToken);

                //Rn0041 - Ocorrência Finalizada 
                entityHistorico.DscFinalizacao = request.DscFinalizacao;
                entityHistorico.AlteradoPor = request.AlteradoPor;
                entityHistorico.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodRelato;
            }
        }

        public string AcoesCorretivasRecomendadas { get; set; }
        public string AlteradoPor { get; set; }
        public int FlgStatusRelato { get; set; }
        public int CodRelato { get; set; }
        public string DscFinalizacao { get; set; }
    }
}
