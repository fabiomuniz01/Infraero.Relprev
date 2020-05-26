using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.ConfigurarAmbiente.Commands.CreateConfigurarAmbiente
{
    public class CreateConfigurarAmbienteCommand : IRequest<long>
    {
        public class CreateConfigurarAmbienteCommandHandler : IRequestHandler<CreateConfigurarAmbienteCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateConfigurarAmbienteCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateConfigurarAmbienteCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.ConfigurarAmbiente
                {
                    ParecerTecnico = request.ParecerTecnico,
                    DevolvidoParaComplemento = request.DevolvidoParaComplemento,
                    TempoNotificacaoParaResponder = request.TempoNotificacaoParaResponder,
                    TextoMotivoCancelamento = request.TextoMotivoCancelamento,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.ConfigurarAmbiente.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodConfigurarAmbiente;
            }
        }

        public string TextoMotivoCancelamento { get; set; }

        public int TempoNotificacaoParaResponder { get; set; }

        public int DevolvidoParaComplemento { get; set; }

        public int ParecerTecnico { get; set; }

        public string CriadoPor { get; set; }

        
    }
}
