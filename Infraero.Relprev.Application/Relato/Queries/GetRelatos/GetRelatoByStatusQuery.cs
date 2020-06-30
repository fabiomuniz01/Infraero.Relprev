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
    public class GetRelatoByStatusQuery : IRequest<List<RelatoDto>>
    {
        public int Id { get; set; }

        public class GetRelatoByStatusQueryQueryHandler : IRequestHandler<GetRelatoByStatusQuery, List<RelatoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetRelatoByStatusQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<RelatoDto>> Handle(GetRelatoByStatusQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Relato
                        .Where(r=>r.FlgStatusRelato==request.Id)
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
