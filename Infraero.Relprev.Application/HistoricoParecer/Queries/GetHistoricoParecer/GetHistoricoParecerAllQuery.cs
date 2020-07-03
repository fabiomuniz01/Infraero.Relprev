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

namespace Infraero.Relprev.Application.HistoricoParecer.Queries.GetHistoricoParecer
{
    public class GetHistoricoParecerAllQuery : IRequest<List<HistoricoParecerDto>>
    {
        public class GetHistoricoParecerAllQueryQueryHandler : IRequestHandler<GetHistoricoParecerAllQuery, List<HistoricoParecerDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetHistoricoParecerAllQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<HistoricoParecerDto>> Handle(GetHistoricoParecerAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.HistoricoParecer
                        .ProjectTo<HistoricoParecerDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodHistoricoParecer)
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
