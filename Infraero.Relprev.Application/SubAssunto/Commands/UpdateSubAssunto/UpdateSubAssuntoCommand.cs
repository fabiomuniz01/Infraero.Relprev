using System;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssuntos.Queries.GetSubAssuntos;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.SubAssuntos.Commands.UpdateSubAssunto
{
    public partial class UpdateSubAssuntoCommand : IRequest<bool>
    {
        public int CodSubAssunto { get; set; }
        public string DscSubAssunto { get; set; }
        public int CodAssunto { get; set; }

        public Assunto CodAssuntoNavigation { get; set; }
        public ICollection<Relato> Relato { get; set; }

        public class UpdateSubAssuntoCommandHandler : IRequestHandler<UpdateSubAssuntoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateSubAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateSubAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubAssuntos.FindAsync(request.CodSubAssunto);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(SubAssunto), request.CodSubAssunto);
                }

                entity.CodSubAssunto = request.CodSubAssunto;
                entity.DscSubAssunto = request.DscSubAssunto;
                entity.CodAssunto = request.CodAssunto;
                entity.CodAssuntoNavigation = request.CodAssuntoNavigation;
                entity.Relato = request.Relato;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

    }
}
