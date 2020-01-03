using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class GetLocalByIdQuery : IRequest<LocalDto>
    {
        public int Id { get; set; }

        public class GetLocalByIdQueryHandler : IRequestHandler<GetLocalByIdQuery, LocalDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetLocalByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<LocalDto> Handle(GetLocalByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await Queryable.Where<Domain.Entities.Local>(_context.Local, x=>x.CodLocal==request.Id)
                        .ProjectTo<LocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodLocal)
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
