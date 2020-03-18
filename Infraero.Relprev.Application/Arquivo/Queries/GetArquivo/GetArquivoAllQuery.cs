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

namespace Infraero.Relprev.Application.Arquivo.Queries.GetArquivos
{
    public class GetArquivoAllQuery : IRequest<List<ArquivoDto>>
    {
        public class GetArquivoAllQueryHandler : IRequestHandler<GetArquivoAllQuery, List<ArquivoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetArquivoAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ArquivoDto>> Handle(GetArquivoAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Arquivo
                        .ProjectTo<ArquivoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodArquivo)
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
