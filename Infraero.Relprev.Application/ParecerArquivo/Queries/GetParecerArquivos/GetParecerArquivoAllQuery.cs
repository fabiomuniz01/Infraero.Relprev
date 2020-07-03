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

namespace Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos
{
    public class GetParecerArquivoAllQuery : IRequest<List<ParecerArquivoDto>>
    {
        public class GetParecerArquivoAllQueryHandler : IRequestHandler<GetParecerArquivoAllQuery, List<ParecerArquivoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetParecerArquivoAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ParecerArquivoDto>> Handle(GetParecerArquivoAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ParecerArquivo
                        .ProjectTo<ParecerArquivoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodParecerArquivo)
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
