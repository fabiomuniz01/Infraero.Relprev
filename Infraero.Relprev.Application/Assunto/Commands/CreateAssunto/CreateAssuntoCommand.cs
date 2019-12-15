using System;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.Empresas.Commands.CreateAssunto
{
    public class CreateUnidadeInfraEstruturaCommand : IRequest<long>
    {
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }
        public ICollection<Relato> Relato { get; set; }
        public ICollection<SubAssunto> SubAssunto { get; set; }

        public class CreateAssuntoCommandHandler : IRequestHandler<CreateUnidadeInfraEstruturaCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateUnidadeInfraEstruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = new Assunto
                {
                    DscAssunto = request.DscAssunto,
                    Relato = request.Relato, 
                    SubAssunto = request.SubAssunto
                };

                _context.Assuntos.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodAssunto;
            }
        }


    }
}
