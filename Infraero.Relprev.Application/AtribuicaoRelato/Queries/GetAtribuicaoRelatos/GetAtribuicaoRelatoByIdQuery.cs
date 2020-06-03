using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos
{
    public class GetAtribuicaoRelatoByIdQuery : IRequest<AtribuicaoRelatoDto>
    {
        public int Id { get; set; }

        public class GetAtribuicaoRelatoByIdQueryHandler : IRequestHandler<GetAtribuicaoRelatoByIdQuery, AtribuicaoRelatoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAtribuicaoRelatoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<AtribuicaoRelatoDto> Handle(GetAtribuicaoRelatoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await Queryable.Where<Domain.Entities.AtribuicaoRelato>(_context.AtribuicaoRelato, x=>x.CodAtribuicaoRelato==request.Id)
                        .ProjectTo<AtribuicaoRelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAtribuicaoRelato)
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
