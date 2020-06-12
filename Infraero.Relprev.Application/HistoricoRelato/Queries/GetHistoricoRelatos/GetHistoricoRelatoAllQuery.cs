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

namespace Infraero.Relprev.Application.HistoricoRelato.Queries.GetHistoricoRelatos
{
    public class GetHistoricoRelatoAllQuery : IRequest<List<HistoricoRelatoDto>>
    {
        public class GetHistoricoRelatoAllQueryQueryHandler : IRequestHandler<GetHistoricoRelatoAllQuery, List<HistoricoRelatoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetHistoricoRelatoAllQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<HistoricoRelatoDto>> Handle(GetHistoricoRelatoAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.HistoricoRelato
                        .ProjectTo<HistoricoRelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodHistoricoRelato)
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
