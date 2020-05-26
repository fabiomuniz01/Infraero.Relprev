using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.ConfigurarAmbiente.Commands.UpdateConfigurarAmbiente
{
    public partial class UpdateConfigurarAmbienteCommand : IRequest<bool>
    {

        public class UpdateConfigurarAmbienteCommandHandler : IRequestHandler<UpdateConfigurarAmbienteCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateConfigurarAmbienteCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateConfigurarAmbienteCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.ConfigurarAmbiente.FindAsync(request.CodConfigurarAmbiente);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.ConfigurarAmbiente), request.CodConfigurarAmbiente);
                }

                entity.ParecerTecnico = request.ParecerTecnico;
                entity.DevolvidoParaComplemento = request.DevolvidoParaComplemento;
                entity.TempoNotificacaoParaResponder = request.TempoNotificacaoParaResponder;
                entity.TextoMotivoCancelamento = request.TextoMotivoCancelamento;
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
        public int CodConfigurarAmbiente { get; set; }
    }
}
