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

namespace Infraero.Relprev.Application.Modulo.Queries.GetModulos
{
    public class GetModuloAllQuery : IRequest<List<ModuloDto>>
    {
        public class GetModuloAllQueryHandler : IRequestHandler<GetModuloAllQuery, List<ModuloDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetModuloAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ModuloDto>> Handle(GetModuloAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Modulo
                        .ProjectTo<ModuloDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodModulo)
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
