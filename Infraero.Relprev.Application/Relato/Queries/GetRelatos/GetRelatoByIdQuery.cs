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
    public class GetRelatoByIdQuery : IRequest<RelatoDto>
    {
        public int Id { get; set; }

        public class GetRelatoByIdQueryHandler : IRequestHandler<GetRelatoByIdQuery, RelatoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetRelatoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<RelatoDto> Handle(GetRelatoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Relato
                        .Where(x => x.CodRelato == request.Id)
                        .ProjectTo<RelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodRelato)
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
