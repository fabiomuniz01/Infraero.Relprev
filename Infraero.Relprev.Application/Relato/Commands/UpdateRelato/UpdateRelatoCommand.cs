using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Relato.Commands.UpdateRelato
{
    public partial class UpdateRelatoCommand : IRequest<bool>
    {

        public class UpdateRelatoCommandHandler : IRequestHandler<UpdateRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Relato.FindAsync(request.CodRelato);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Relato), request.CodUnidadeInfraestrutura);
                }

                
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscRelato { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int CodRelato { get; set; }
    }
}
