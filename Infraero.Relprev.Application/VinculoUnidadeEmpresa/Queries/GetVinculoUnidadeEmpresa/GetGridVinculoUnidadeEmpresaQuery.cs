using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa
{
    public class GetGridVinculoUnidadeEmpresasQuery : IRequest<GridVinculoUnidadeEmpresa>
    {
        public class GetGridVinculoUnidadeEmpresasQueryHandler : IRequestHandler<GetGridVinculoUnidadeEmpresasQuery, GridVinculoUnidadeEmpresa>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridVinculoUnidadeEmpresasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridVinculoUnidadeEmpresa> Handle(GetGridVinculoUnidadeEmpresasQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoUnidadeEmpresa
                        .ProjectTo<VinculoUnidadeEmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodVinculoUnidadeEmpresa)
                        .ToListAsync(cancellationToken);

                    var grid = new GridVinculoUnidadeEmpresa
                    {
                        aaData = responseModel,
                        sEcho = 0,
                        iTotalRecords = responseModel.Count(),
                        recordsFiltered = responseModel.Count(),
                        iTotalDisplayRecords = 1
                    };

                    return grid;
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
