using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Assunto.Commands.UpdateAssunto
{
    public partial class UpdateAssuntoCommand : IRequest<bool>
    {
        
        public class UpdateAssuntoCommandHandler : IRequestHandler<UpdateAssuntoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Assuntos.FindAsync(request.CodAssunto);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.CodAssunto);
                }

                entity.DscAssunto = request.DscAssunto;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscAssunto { get; set; }

        public int CodAssunto { get; set; }

        public string AlteradoPor { get; set; }
    }
}
