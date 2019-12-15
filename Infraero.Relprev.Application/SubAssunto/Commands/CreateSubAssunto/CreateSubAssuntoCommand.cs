using System;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.SubAssuntos.Commands.CreateSubAssunto
{
    public class CreateSubAssuntoCommand : IRequest<long>
    {
        public int CodSubAssunto { get; set; }
        public string DscSubAssunto { get; set; }
        public int CodAssunto { get; set; }

        public Assunto CodAssuntoNavigation { get; set; }
        public ICollection<Relato> Relato { get; set; }

        public class CreateSubAssuntoCommandHandler : IRequestHandler<CreateSubAssuntoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateSubAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateSubAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = new SubAssunto
                { 
                    CodAssunto = request.CodAssunto,
                    DscSubAssunto = request.DscSubAssunto,
                    CodSubAssunto = request.CodSubAssunto,
                    Relato = request.Relato
                };

                _context.SubAssuntos.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodSubAssunto;
            }
        }

        
    }
}
