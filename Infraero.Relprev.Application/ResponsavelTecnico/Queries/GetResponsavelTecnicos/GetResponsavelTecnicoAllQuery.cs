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

namespace Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos
{
    public class GetResponsavelTecnicoAllQuery : IRequest<List<ResponsavelTecnicoDto>>
    {
        public class GetResponsavelTecnicoAllQueryQueryHandler : IRequestHandler<GetResponsavelTecnicoAllQuery, List<ResponsavelTecnicoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetResponsavelTecnicoAllQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ResponsavelTecnicoDto>> Handle(GetResponsavelTecnicoAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ResponsavelTecnico
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.NomResponsavelTecnico)
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
