using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos
{
    public class GetSubAssuntosQuery : IRequest<List<SubAssuntoDto>>
    {
        public class GetSubAssuntosQueryHandler : IRequestHandler<GetSubAssuntosQuery, List<SubAssuntoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubAssuntosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<SubAssuntoDto>> Handle(GetSubAssuntosQuery request, CancellationToken cancellationToken)
            {
                return await _context.SubAssunto
                    .ProjectTo<SubAssuntoDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodSubAssunto)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
