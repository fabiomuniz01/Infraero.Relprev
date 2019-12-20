using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Local.Commands.CreateLocal
{
    public class CreateLocalCommand : IRequest<long>
    {
        public class CreateLocalCommandHandler : IRequestHandler<CreateLocalCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Local
                {
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    DscLocal = request.DscLocal,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.Locals.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodLocal;
            }
        }

        public string CriadoPor { get; set; }

        public int CodLocal { get; set; }
        public string DscLocal { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
    }
}
