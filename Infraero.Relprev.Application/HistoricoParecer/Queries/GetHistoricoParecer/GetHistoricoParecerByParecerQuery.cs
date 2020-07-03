using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.HistoricoParecer.Queries.GetHistoricoParecer
{
    public class GetHistoricoParecerByIdQuery : IRequest<HistoricoParecerDto>
    {
        public int Id { get; set; }

        public class GetHistoricoParecerByIdQueryHandler : IRequestHandler<GetHistoricoParecerByIdQuery, HistoricoParecerDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetHistoricoParecerByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<HistoricoParecerDto> Handle(GetHistoricoParecerByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.HistoricoParecer
                        .Where(x => x.CodParecer == request.Id)
                        .ProjectTo<HistoricoParecerDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodHistoricoParecer)
                        .FirstOrDefaultAsync(cancellationToken);

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
