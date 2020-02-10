using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.CreateVinculoUnidadeEmpresa
{
    public class CreateVinculoUnidadeEmpresaCommand : IRequest<long>
    {

        public class CreateVinculoUnidadeEmpresaCommandHandler : IRequestHandler<CreateVinculoUnidadeEmpresaCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateVinculoUnidadeEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateVinculoUnidadeEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.VinculoUnidadeEmpresa
                {
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    CodEmpresa = request.CodEmpresa,
                    NomUnidadeInfraestrutura = request.NomUnidadeInfraestrutura,
                    NomEmpresa = request.NomEmpresa,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.VinculoUnidadeEmpresa.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodVinculoUnidadeEmpresa;
            }
        }
        public int CodUnidadeInfraestrutura { get; set; }
        public string NomUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string NomEmpresa { get; set; }
        public string CriadoPor { get; set; }

        
    }
}
