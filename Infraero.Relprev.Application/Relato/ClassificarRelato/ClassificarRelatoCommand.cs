using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Relato.Commands.ClassificarRelato
{
    public partial class ClassificarRelatoCommand : IRequest<bool>
    {

        public class ClassificarRelatoCommandHandler : IRequestHandler<ClassificarRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public ClassificarRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(ClassificarRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Relato.FindAsync(request.CodRelato);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Relato), request.CodUnidadeInfraestrutura);
                }

                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                entity.FlgStatusRelato = request.FlgStatusRelato;
                entity.CodLocal = request.CodLocal;
                entity.CodSubLocal = request.CodSubLocal;
                entity.CodAssunto = request.CodAssunto;
                entity.CodSubAssunto = request.CodSubAssunto;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
        public int CodRelato { get; set; }

        public string DscRelato { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int CodLocal { get; set; }
        public int CodSubLocal { get; set; }
        public int CodAssunto { get; set; }
        public int CodSubAssunto { get; set; }
        public int FlgStatusRelato { get; set; }

    }
}
