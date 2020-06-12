using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.HistoricoRelato.Commands.CreateHistoricoRelato
{
    public class CreateHistoricoRelatoCommand : IRequest<long>
    {
        public class CreateHistoricoRelatoCommandHandler : IRequestHandler<CreateHistoricoRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateHistoricoRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateHistoricoRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.HistoricoRelato
                {
                    
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.HistoricoRelato.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodHistoricoRelato;
            }
        }

        public string TextoMotivoCancelamento { get; set; }

        public int TempoNotificacaoParaResponder { get; set; }

        public int DevolvidoParaComplemento { get; set; }

        public int ParecerTecnico { get; set; }

        public string CriadoPor { get; set; }

        
    }
}
