using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa
{
    public class GetVinculoUnidadeEmpresaAllQuery : IRequest<List<VinculoUnidadeEmpresaDto>>
    {
        public class GetVinculoUnidadeEmpresaAllQueryHandler : IRequestHandler<GetVinculoUnidadeEmpresaAllQuery, List<VinculoUnidadeEmpresaDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVinculoUnidadeEmpresaAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<VinculoUnidadeEmpresaDto>> Handle(GetVinculoUnidadeEmpresaAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoUnidadeEmpresa
                        .ProjectTo<VinculoUnidadeEmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodVinculoUnidadeEmpresa)
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
