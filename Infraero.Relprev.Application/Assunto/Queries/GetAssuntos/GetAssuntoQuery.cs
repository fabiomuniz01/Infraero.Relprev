using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos
{
    public class GetUnidadeInfraEstruturaQuery : IRequest<GridUnidadeInfraEstrutura>
    {
        public class GetGridAssuntosQueryHandler : IRequestHandler<GetUnidadeInfraEstruturaQuery, GridUnidadeInfraEstrutura>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridAssuntosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridUnidadeInfraEstrutura> Handle(GetUnidadeInfraEstruturaQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var vm = new UnidadeInfraEstruturaVm();

                    var responseModel = await _context.Assuntos
                        .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAssunto)
                        .ToListAsync(cancellationToken);

                    var grid = new GridUnidadeInfraEstrutura();

                    var data = responseModel
                        .Select(
                            c =>
                                new UnidadeInfraEstruturaDto()
                                {
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
