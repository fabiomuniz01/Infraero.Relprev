using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa
{
    public class ExistVinculoQuery : IRequest<VinculoResponsavelEmpresaDto>
    {
        public int CodVinculoResponsavelEmpresa { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }

        public class GetVinculoResponsavelEmpresaByIdQueryHandler : IRequestHandler<ExistVinculoQuery, VinculoResponsavelEmpresaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVinculoResponsavelEmpresaByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VinculoResponsavelEmpresaDto> Handle(ExistVinculoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoResponsavelEmpresa
                        .Where(x => x.CodEmpresa == request.CodEmpresa && x.CodUnidadeInfraestrutura == request.CodUnidadeInfraestrutura)
                        .ProjectTo<VinculoResponsavelEmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodEmpresa)
                        .FirstOrDefaultAsync(cancellationToken);

                    return responseModel;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

    }
}
