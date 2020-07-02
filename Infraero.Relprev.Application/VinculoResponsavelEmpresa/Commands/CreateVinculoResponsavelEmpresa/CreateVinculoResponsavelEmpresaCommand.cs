using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Commands.CreateVinculoResponsavelEmpresa
{
    public class CreateVinculoResponsavelEmpresaCommand : IRequest<long>
    {

        public class CreateVinculoResponsavelEmpresaCommandHandler : IRequestHandler<CreateVinculoResponsavelEmpresaCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateVinculoResponsavelEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateVinculoResponsavelEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.VinculoResponsavelEmpresa
                {
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    CodEmpresa = request.CodEmpresa,
                    CodResponsavelTecnico = request.CodResponsavelTecnico,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.VinculoResponsavelEmpresa.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodVinculoResponsavelEmpresa;
            }
        }

        public int CodResponsavelTecnico { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string CriadoPor { get; set; }

        
    }
}
