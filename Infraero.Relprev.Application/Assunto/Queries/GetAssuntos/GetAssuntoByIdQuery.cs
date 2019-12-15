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
using Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos;

namespace Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos
{
    public class GetUnidadeInfraEstruturaByIdQuery : IRequest<UnidadeInfraEstruturaDto>
    {
        public int Id { get; set; }

        public class GetAssuntoByIdQueryHandler : IRequestHandler<GetUnidadeInfraEstruturaByIdQuery, UnidadeInfraEstruturaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAssuntoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UnidadeInfraEstruturaDto> Handle(GetUnidadeInfraEstruturaByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Assuntos
                        .Where(x=>x.CodAssunto==request.Id)
                        .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAssunto)
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
