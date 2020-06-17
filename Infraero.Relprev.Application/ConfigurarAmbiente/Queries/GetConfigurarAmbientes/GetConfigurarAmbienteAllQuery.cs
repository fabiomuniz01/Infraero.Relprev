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

namespace Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes
{
    public class GetConfigurarAmbienteAllQuery : IRequest<List<ConfigurarAmbienteDto>>
    {
        public class GetConfigurarAmbienteAllQueryHandler : IRequestHandler<GetConfigurarAmbienteAllQuery, List<ConfigurarAmbienteDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetConfigurarAmbienteAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ConfigurarAmbienteDto>> Handle(GetConfigurarAmbienteAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ConfigurarAmbiente
                        .ProjectTo<ConfigurarAmbienteDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodConfigurarAmbiente)
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
