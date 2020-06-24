using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Relato.Commands.UpdateRelato
{
    public partial class UpdateRelatoAtribuidoCommand : IRequest<bool>
    {

        public class UpdateRelatoCommandHandler : IRequestHandler<UpdateRelatoAtribuidoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateRelatoAtribuidoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Relato.FindAsync(request.CodRelato);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Relato), request.CodUnidadeInfraestrutura);
                }

                entity.FlgStatusRelato = request.FlgStatusRelato;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                await _context.SaveChangesAsync(cancellationToken);

                var entityHistorico = await _context.HistoricoRelato
                    .Where(x => x.CodRelato == entity.CodRelato)
                    .FirstOrDefaultAsync(cancellationToken);

                //Rn0039 - Ocorrência Atribuída 
                entityHistorico.DscAtribuicao = request.DscAtribuicao;
                entityHistorico.AlteradoPor = request.AlteradoPor;
                entityHistorico.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscRelato { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int CodRelato { get; set; }
        public int FlgStatusRelato { get; set; }
        public string DscAtribuicao { get; set; }
    }
}
