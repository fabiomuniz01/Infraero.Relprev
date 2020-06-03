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

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class GetLocalByIdUnidadeQuery : IRequest<List<LocalDto>>
    {
        private int v { get; set; }

       

        public int IdUnidade { get; set; }
        public int Id { get; set; }
        public class GetLocalByIdUnidadeQueryHandler : IRequestHandler<GetLocalByIdUnidadeQuery, List<LocalDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetLocalByIdUnidadeQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<LocalDto>> Handle(GetLocalByIdUnidadeQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await Queryable.Where<Domain.Entities.Local>(_context.Local, x=>x.CodUnidadeInfraestrutura==request.IdUnidade)
                        .ProjectTo<LocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.DscLocal)
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
