using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Relato.Commands.CreateRelato
{
    public class CreateRelatoCommand : IRequest<long>
    {
        public class CreateRelatoCommandHandler : IRequestHandler<CreateRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Relato
                {
                    
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.Relato.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodRelato;
            }
        }

        public string CriadoPor { get; set; }

        public int CodRelato { get; set; }
        public string DscRelato { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
    }
}
