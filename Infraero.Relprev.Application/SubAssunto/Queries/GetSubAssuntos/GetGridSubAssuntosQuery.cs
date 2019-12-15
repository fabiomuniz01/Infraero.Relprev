using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos
{
    public class GetGridSubAssuntosQuery : IRequest<GridSubAssunto>
    {
        public class GetGridSubAssuntosQueryHandler : IRequestHandler<GetGridSubAssuntosQuery, GridSubAssunto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridSubAssuntosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridSubAssunto> Handle(GetGridSubAssuntosQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var vm = new SubAssuntoVm();

                    var responseModel = await _context.SubAssuntos
                        .ProjectTo<SubAssuntoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodSubAssunto)
                        .ToListAsync(cancellationToken);

                    var grid = new GridSubAssunto();

                    var data = responseModel
                        .Select(
                            c =>
                                new SubAssuntoDto()
                                {
                                    CodSubAssunto = c.CodSubAssunto, 
                                    CodAssunto = c.CodAssunto,
                                    CodAssuntoNavigation = c.CodAssuntoNavigation,
                                    DscSubAssunto = c.DscSubAssunto,
                                    Relato = c.Relato
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
