using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Parecer.Queries.GetParecer
{
    public class GetParecerByIdQuery : IRequest<ParecerDto>
    {
        public int Id { get; set; }

        public class GetParecerByIdQueryHandler : IRequestHandler<GetParecerByIdQuery, ParecerDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetParecerByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ParecerDto> Handle(GetParecerByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Parecer
                        .Where(x => x.CodParecer == request.Id)
                        .ProjectTo<ParecerDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodParecer)
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
