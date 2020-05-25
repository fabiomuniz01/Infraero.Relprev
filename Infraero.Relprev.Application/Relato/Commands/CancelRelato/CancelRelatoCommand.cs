using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Relato.Commands.CancelRelato
{
    public partial class CancelRelatoCommand : IRequest<bool>
    {

        public class CancelRelatoCommandHandler : IRequestHandler<CancelRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public CancelRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(CancelRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Relato.FindAsync(request.CodRelato);

                //if (entity == null)
                //{
                //    throw new NotFoundException(nameof(Domain.Entities.Relato), request.CodUnidadeInfraestrutura);
                //}

                
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                entity.FlagAtivo = false;
                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscMotivoCancelamento { get; set; }
        public string AlteradoPor { get; set; }
        public int CodRelato { get; set; }
    }
}
