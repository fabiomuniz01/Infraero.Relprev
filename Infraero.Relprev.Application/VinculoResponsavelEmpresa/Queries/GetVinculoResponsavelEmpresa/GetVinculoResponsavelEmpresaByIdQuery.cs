using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresas
{
    public class GetVinculoResponsavelEmpresaByIdQuery : IRequest<VinculoResponsavelEmpresaDto>
    {
        public int CodVinculoResponsavelEmpresa { get; set; }

        public class GetVinculoResponsavelEmpresaByIdQueryHandler : IRequestHandler<GetVinculoResponsavelEmpresaByIdQuery, VinculoResponsavelEmpresaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVinculoResponsavelEmpresaByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VinculoResponsavelEmpresaDto> Handle(GetVinculoResponsavelEmpresaByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoResponsavelEmpresa
                        .Where(x => x.CodVinculoResponsavelEmpresa == request.CodVinculoResponsavelEmpresa)
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
