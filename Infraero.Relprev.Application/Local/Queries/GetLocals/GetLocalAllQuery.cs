using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class GetLocalAllQuery : IRequest<List<LocalDto>>
    {
        public class GetLocalAllQueryHandler : IRequestHandler<GetLocalAllQuery, List<LocalDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetLocalAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<LocalDto>> Handle(GetLocalAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Local
                        .ProjectTo<LocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodLocal)
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
