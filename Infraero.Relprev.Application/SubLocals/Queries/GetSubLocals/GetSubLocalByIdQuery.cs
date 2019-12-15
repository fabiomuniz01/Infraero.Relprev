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

namespace Infraero.Relprev.Application.SubLocals.Queries.GetSubLocals
{
    public class GetSubLocalByIdQuery : IRequest<SubLocalDto>
    {
        public int Id { get; set; }

        public class GetSubLocalByIdQueryHandler : IRequestHandler<GetSubLocalByIdQuery, SubLocalDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubLocalByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SubLocalDto> Handle(GetSubLocalByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.SubLocals
                        .Where(x=>x.CodSubLocal==request.Id)
                        .ProjectTo<SubLocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodSubLocal)
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
