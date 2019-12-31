using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal
{
    public class CreateSubLocalCommand : IRequest<long>
    {
        public class CreateSubLocalCommandHandler : IRequestHandler<CreateSubLocalCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateSubLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateSubLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.SubLocal
                {
                    CodLocal = request.CodLocal,
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    DscSubLocal = request.DscSubLocal,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.SubLocal.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodSubLocal;
            }
        }

        public string CriadoPor { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
    }
}
