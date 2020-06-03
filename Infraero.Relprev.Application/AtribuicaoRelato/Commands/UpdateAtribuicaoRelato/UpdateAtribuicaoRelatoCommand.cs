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

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.AtribuicaoRelato), request.CodUnidadeInfraestrutura);
                }

                
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscAtribuicaoRelato { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int CodAtribuicaoRelato { get; set; }
    }
}
