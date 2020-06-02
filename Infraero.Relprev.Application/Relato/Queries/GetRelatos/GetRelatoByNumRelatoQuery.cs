using System;
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
    public class GetRelatoByNumRelatoQuery : IRequest<RelatoDto>
    {
        public string numRelato { get; set; }

        public class GetRelatoByNumRelatoQueryHandler : IRequestHandler<GetRelatoByNumRelatoQuery, RelatoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetRelatoByNumRelatoQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<RelatoDto> Handle(GetRelatoByNumRelatoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Relato
                        .Where(x => x.NumRelato == request.numRelato)
                        .ProjectTo<RelatoDto>(_mapper.ConfigurationProvider)
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
