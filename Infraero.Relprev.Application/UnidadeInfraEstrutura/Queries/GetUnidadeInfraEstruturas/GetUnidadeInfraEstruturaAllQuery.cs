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

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class GetUnidadeInfraEstruturaAllQuery : IRequest<List<UnidadeInfraEstruturaDto>>
    {
        public class GetUnidadeInfraEstruturaAllQueryHandler : IRequestHandler<GetUnidadeInfraEstruturaAllQuery, List<UnidadeInfraEstruturaDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUnidadeInfraEstruturaAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<UnidadeInfraEstruturaDto>> Handle(GetUnidadeInfraEstruturaAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.UnidadeInfraestrutura
                        .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodUnidadeInfraestrutura)
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
