using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals
{
    public class GetSubLocalsQuery : IRequest<List<SubLocalDto>>
    {
        public class GetSubLocalsQueryHandler : IRequestHandler<GetSubLocalsQuery, List<SubLocalDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubLocalsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<SubLocalDto>> Handle(GetSubLocalsQuery request, CancellationToken cancellationToken)
            {
                return await _context.SubLocal
                    .ProjectTo<SubLocalDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodSubLocal)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
