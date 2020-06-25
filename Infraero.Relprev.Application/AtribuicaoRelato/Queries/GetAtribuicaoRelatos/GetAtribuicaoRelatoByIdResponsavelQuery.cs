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
    public class GetAtribuicaoRelatoByIdResponsavelQuery : IRequest<List<AtribuicaoRelatoDto>>
    {
        public int Id { get; set; }

        public class GetAtribuicaoRelatoByIdResponsavelQueryHandler : IRequestHandler<GetAtribuicaoRelatoByIdResponsavelQuery, List<AtribuicaoRelatoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAtribuicaoRelatoByIdResponsavelQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<AtribuicaoRelatoDto>> Handle(GetAtribuicaoRelatoByIdResponsavelQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.AtribuicaoRelato
                        .Where(r=>r.CodResponsavelTecnico==request.Id)
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
