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

namespace Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos
{
    public class GetRelatoArquivoByIdRelatoQuery : IRequest<List<RelatoArquivoDto>>
    {
        public int Id { get; set; }

        public class GetRelatoArquivoByIdRelatoQueryHandler : IRequestHandler<GetRelatoArquivoByIdRelatoQuery, List<RelatoArquivoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetRelatoArquivoByIdRelatoQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<RelatoArquivoDto>> Handle(GetRelatoArquivoByIdRelatoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.RelatoArquivo
                        .Where(x=>x.CodRelato==request.Id)
                        .ProjectTo<RelatoArquivoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodRelatoArquivo)
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
