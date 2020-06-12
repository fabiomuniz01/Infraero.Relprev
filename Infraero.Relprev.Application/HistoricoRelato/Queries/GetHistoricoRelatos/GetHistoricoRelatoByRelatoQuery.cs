using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.HistoricoRelato.Queries.GetHistoricoRelatos
{
    public class GetHistoricoRelatoByIdQuery : IRequest<HistoricoRelatoDto>
    {
        public int Id { get; set; }

        public class GetHistoricoRelatoByIdQueryHandler : IRequestHandler<GetHistoricoRelatoByIdQuery, HistoricoRelatoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetHistoricoRelatoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<HistoricoRelatoDto> Handle(GetHistoricoRelatoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.HistoricoRelato
                        .Where(x => x.CodRelato == request.Id)
                        .ProjectTo<HistoricoRelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodHistoricoRelato)
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
