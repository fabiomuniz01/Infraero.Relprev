using System;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.Assuntos.Commands.UpdateAssunto
{
    public partial class UpdateAssuntosCommand : IRequest<bool>
    {
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }
        public ICollection<Relato> Relato { get; set; }
        public ICollection<SubAssunto> SubAssunto { get; set; }

        public class UpdateAssuntoCommandHandler : IRequestHandler<UpdateAssuntosCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateAssuntosCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Assuntos.FindAsync(request.CodAssunto);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.CodAssunto);
                }

                entity.CodAssunto = request.CodAssunto; 
                entity.DscAssunto = request.DscAssunto; 
                entity.Relato = request.Relato;
                entity.SubAssunto= request.SubAssunto;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

    }
}
