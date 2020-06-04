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

namespace Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos
{
    public class GetSubAssuntoAllQuery : IRequest<List<SubAssuntoDto>>
    {
        public class GetSubAssuntoAllQueryHandler : IRequestHandler<GetSubAssuntoAllQuery, List<SubAssuntoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubAssuntoAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<SubAssuntoDto>> Handle(GetSubAssuntoAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.SubAssunto
                        .ProjectTo<SubAssuntoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.DscSubAssunto)
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
