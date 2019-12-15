using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.SubAssuntos.Queries.GetSubAssuntos
{
    public class GetSubAssuntoByIdQuery : IRequest<SubAssuntoDto>
    {
        public int Id { get; set; }

        public class GetSubAssuntoByIdQueryHandler : IRequestHandler<GetSubAssuntoByIdQuery, SubAssuntoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubAssuntoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SubAssuntoDto> Handle(GetSubAssuntoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.SubAssuntos
                        .Where(x=>x.CodSubAssunto==request.Id)
                        .ProjectTo<SubAssuntoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodSubAssunto)
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
