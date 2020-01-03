using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal
{
    public partial class UpdateSubLocalCommand : IRequest<bool>
    {

        public class UpdateSubLocalCommandHandler : IRequestHandler<UpdateSubLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateSubLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateSubLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubLocal.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.SubLocal), request.Id);
                }

                entity.CodLocal = request.CodLocal;
                entity.CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura;
                entity.DscSubLocal = request.DscSubLocal;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string AlteradoPor { get; set; }

        public int Id { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodLocal { get; set; }
        public string DscSubLocal { get; set; }
    }
}
