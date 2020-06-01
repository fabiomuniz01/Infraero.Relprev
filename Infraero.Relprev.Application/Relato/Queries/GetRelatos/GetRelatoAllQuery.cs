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

namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class GetRelatoAllQuery : IRequest<List<RelatoDto>>
    {
        public class GetRelatoAllQueryQueryHandler : IRequestHandler<GetRelatoAllQuery, List<RelatoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetRelatoAllQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<RelatoDto>> Handle(GetRelatoAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Relato
                        .ProjectTo<RelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodRelato)
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
