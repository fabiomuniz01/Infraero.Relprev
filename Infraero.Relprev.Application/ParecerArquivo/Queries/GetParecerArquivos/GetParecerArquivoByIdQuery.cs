using System;
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
    public class GetParecerArquivoByIdQuery : IRequest<ParecerArquivoDto>
    {
        public int Id { get; set; }

        public class GetParecerArquivoByIdQueryHandler : IRequestHandler<GetParecerArquivoByIdQuery, ParecerArquivoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetParecerArquivoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ParecerArquivoDto> Handle(GetParecerArquivoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ParecerArquivo
                        .Where(x=>x.CodParecerArquivo==request.Id)
                        .ProjectTo<ParecerArquivoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodParecerArquivo)
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
