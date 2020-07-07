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

namespace Infraero.Relprev.Application.Parecer.Queries.GetParecer
{
    public class GetParecerByIdRelatoQuery : IRequest<List<ParecerDto>>
    {
        public int Id { get; set; }

        public class GetParecerByIdRelatoQueryQueryHandler : IRequestHandler<GetParecerByIdRelatoQuery, List<ParecerDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetParecerByIdRelatoQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ParecerDto>> Handle(GetParecerByIdRelatoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Parecer
                        .Where(r => r.CodRelato == request.Id)
                        .ProjectTo<ParecerDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodParecer)
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
