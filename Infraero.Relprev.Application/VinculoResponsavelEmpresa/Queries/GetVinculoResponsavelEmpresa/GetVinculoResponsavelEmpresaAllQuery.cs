using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa
{
    public class GetVinculoResponsavelEmpresaAllQuery : IRequest<List<VinculoResponsavelEmpresaDto>>
    {
        public class GetVinculoResponsavelEmpresaAllQueryHandler : IRequestHandler<GetVinculoResponsavelEmpresaAllQuery, List<VinculoResponsavelEmpresaDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVinculoResponsavelEmpresaAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<VinculoResponsavelEmpresaDto>> Handle(GetVinculoResponsavelEmpresaAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoResponsavelEmpresa
                        .ProjectTo<VinculoResponsavelEmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodVinculoResponsavelEmpresa)
                        .ToListAsync(cancellationToken);

                    
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
