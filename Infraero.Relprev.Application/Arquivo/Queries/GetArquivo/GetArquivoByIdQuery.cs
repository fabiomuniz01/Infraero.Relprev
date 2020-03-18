using System;
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
    public class GetArquivoByIdQuery : IRequest<ArquivoDto>
    {
        public int Id { get; set; }

        public class GetArquivoByIdQueryHandler : IRequestHandler<GetArquivoByIdQuery, ArquivoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetArquivoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ArquivoDto> Handle(GetArquivoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Arquivo
                        .Where(x=>x.CodArquivo==request.Id)
                        .ProjectTo<ArquivoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodArquivo)
                        .FirstOrDefaultAsync(cancellationToken);

                    
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
