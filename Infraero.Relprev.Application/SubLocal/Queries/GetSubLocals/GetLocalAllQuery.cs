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

namespace Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals
{
    public class GetSubLocalAllQuery : IRequest<List<SubLocalDto>>
    {
        public class GetSubLocalAllQueryHandler : IRequestHandler<GetSubLocalAllQuery, List<SubLocalDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubLocalAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<SubLocalDto>> Handle(GetSubLocalAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.SubLocal
                        .ProjectTo<SubLocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.DscSubLocal)
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
