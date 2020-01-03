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

namespace Infraero.Relprev.Application.Perfil.Queries.GetPerfils
{
    public class GetPerfilAllQuery : IRequest<List<PerfilDto>>
    {
        public class GetPerfilAllQueryHandler : IRequestHandler<GetPerfilAllQuery, List<PerfilDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetPerfilAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<PerfilDto>> Handle(GetPerfilAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    //var responseModel = await _context.As
                    //    .ProjectTo<PerfilDto>(_mapper.ConfigurationProvider)
                    //    .OrderBy(t => t.CodPerfil)
                    //    .ToListAsync(cancellationToken);

                    
                    return null;
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
