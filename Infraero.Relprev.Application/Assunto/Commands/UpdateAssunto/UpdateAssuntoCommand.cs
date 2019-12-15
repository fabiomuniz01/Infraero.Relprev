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
                var entity = await _context.Assuntos.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.Id);
                }

                //entity.NomRazaoSocial = request.NomRazaoSocial;
                //entity.NumCnpj = request.NumCnpj;
                //entity.NumTelefone = request.NumTelefone;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public int Id { get; set; }

        public string AlteradoPor { get; set; }
    }
}
