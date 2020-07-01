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

namespace Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos
{
    public class GetAtribuicaoRelatoByIdRelatoQuery : IRequest<List<AtribuicaoRelatoDto>>
    {
        public int Id { get; set; }

        public class GetAtribuicaoRelatoByIdRelatoQueryHandler : IRequestHandler<GetAtribuicaoRelatoByIdRelatoQuery, List<AtribuicaoRelatoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAtribuicaoRelatoByIdRelatoQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<AtribuicaoRelatoDto>> Handle(GetAtribuicaoRelatoByIdRelatoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await Queryable
                        .Where(_context.AtribuicaoRelato, x => x.CodRelato == request.Id)
                        .ProjectTo<AtribuicaoRelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAtribuicaoRelato)
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
