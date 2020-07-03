using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.HistoricoParecer.Commands.CreateHistoricoParecer
{
    public class CreateHistoricoParecerCommand : IRequest<long>
    {
        public class CreateHistoricoParecerCommandHandler : IRequestHandler<CreateHistoricoParecerCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateHistoricoParecerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateHistoricoParecerCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.HistoricoParecer
                {
                    
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.HistoricoParecer.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodHistoricoParecer;
            }
        }

        public string TextoMotivoCancelamento { get; set; }

        public int TempoNotificacaoParaResponder { get; set; }

        public int DevolvidoParaComplemento { get; set; }

        public int ParecerTecnico { get; set; }

        public string CriadoPor { get; set; }

        
    }
}
