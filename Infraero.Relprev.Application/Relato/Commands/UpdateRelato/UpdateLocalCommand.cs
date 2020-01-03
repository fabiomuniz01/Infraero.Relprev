using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Local.Commands.UpdateLocal
{
    public partial class UpdateLocalCommand : IRequest<bool>
    {

        public class UpdateLocalCommandHandler : IRequestHandler<UpdateLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Local.FindAsync(request.CodLocal);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Local), request.CodUnidadeInfraestrutura);
                }

                entity.CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura;
                entity.DscLocal = request.DscLocal;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscLocal { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int CodLocal { get; set; }
    }
}
