using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class GetUnidadeInfraEstruturasQuery : IRequest<List<UnidadeInfraEstruturaDto>>
    {
        public class GetUnidadeInfraestruturasQueryHandler : IRequestHandler<GetUnidadeInfraEstruturasQuery, List<UnidadeInfraEstruturaDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUnidadeInfraestruturasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<UnidadeInfraEstruturaDto>> Handle(GetUnidadeInfraEstruturasQuery request, CancellationToken cancellationToken)
            {
                return await _context.UnidadeInfraestrutura
                    .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodUnidadeInfraestrutura)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
