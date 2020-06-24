using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using MediatR;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Commands.UpdateAtribuicaoRelato
{
    public partial class UpdateAtribuicaoRelatoCommand : IRequest<bool>
    {

        public class UpdateAtribuicaoRelatoCommandHandler : IRequestHandler<UpdateAtribuicaoRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateAtribuicaoRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateAtribuicaoRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.AtribuicaoRelato.FindAsync(request.CodAtribuicaoRelato);


                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                entity.FlagAtivo = true;

                await _context.SaveChangesAsync(cancellationToken);

                //Rn0033 - Ocorrencia Atribuída
                var entityHistoricoRelato = new Domain.Entities.HistoricoRelato
                {
                    CodRelato = entity.CodRelato,
                    DscAtribuicao  = "Ocorrência Atribuída, " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    CriadoPor = request.AlteradoPor,
                    DataCriacao = DateTime.Now
                };

                _context.HistoricoRelato.Add(entityHistoricoRelato);

                await _context.SaveChangesAsync(cancellationToken);

                var entityRelato = await _context.Relato.FindAsync(entity.CodRelato);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Relato), entity.CodRelato);
                }
                entityRelato.AlteradoPor = request.AlteradoPor;
                entityRelato.DataAlteracao = DateTime.Now;
                entityRelato.FlgStatusRelato = request.FlgStatusRelato;

                _context.Relato.Update(entityRelato);
                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public int FlgStatusRelato { get; set; }
        public string AlteradoPor { get; set; }
        public int CodAtribuicaoRelato { get; set; }
    }
}
