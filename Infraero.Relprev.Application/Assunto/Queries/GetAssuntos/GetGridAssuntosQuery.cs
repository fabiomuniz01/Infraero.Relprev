using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Assunto.Queries.GetAssuntos
{
    public class GetGridAssuntosQuery : IRequest<GridAssunto>
    {
        public class GetGridAssuntosQueryHandler : IRequestHandler<GetGridAssuntosQuery, GridAssunto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridAssuntosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridAssunto> Handle(GetGridAssuntosQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Assunto
                        .ProjectTo<AssuntoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAssunto)
                        .ToListAsync(cancellationToken);

                    var grid = new GridAssunto();

                    var data = responseModel
                        .Select(
                            c =>
                                new AssuntoDto()
                                {
                                    CodAssunto = c.CodAssunto,
                                    DscAssunto = c.DscAssunto
                                });

                    grid.aaData = data;
                    grid.sEcho = 0;
                    grid.iTotalRecords = data.Count();
                    grid.recordsFiltered = data.Count();
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
