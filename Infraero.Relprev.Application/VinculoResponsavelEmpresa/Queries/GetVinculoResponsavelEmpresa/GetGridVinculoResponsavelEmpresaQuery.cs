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
    public class GetGridVinculoResponsavelEmpresasQuery : IRequest<GridVinculoResponsavelEmpresa>
    {
        public class GetGridVinculoResponsavelEmpresasQueryHandler : IRequestHandler<GetGridVinculoResponsavelEmpresasQuery, GridVinculoResponsavelEmpresa>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridVinculoResponsavelEmpresasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridVinculoResponsavelEmpresa> Handle(GetGridVinculoResponsavelEmpresasQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoResponsavelEmpresa
                        .ProjectTo<VinculoResponsavelEmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodVinculoResponsavelEmpresa)
                        .ToListAsync(cancellationToken);

                    var grid = new GridVinculoResponsavelEmpresa
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
