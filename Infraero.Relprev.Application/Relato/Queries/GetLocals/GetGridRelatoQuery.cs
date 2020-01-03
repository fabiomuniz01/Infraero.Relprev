using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class GetGridRelatoQuery : IRequest<GridRelato>
    {
        public class GetGridRelatosQueryHandler : IRequestHandler<GetGridRelatoQuery, GridRelato>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridRelatosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridRelato> Handle(GetGridRelatoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Relato
                        .ProjectTo<RelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodRelato)
                        .ToListAsync(cancellationToken);

                    var grid = new GridRelato();

                    grid.aaData = responseModel;
                    grid.sEcho = 0;
                    grid.iTotalRecords = responseModel.Count();
                    grid.recordsFiltered = responseModel.Count();
                    grid.iTotalDisplayRecords = 1;
                    return grid;
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
