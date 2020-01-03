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
    public class GetGridLocalsQuery : IRequest<GridLocal>
    {
        public class GetGridLocalsQueryHandler : IRequestHandler<GetGridLocalsQuery, GridLocal>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridLocalsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridLocal> Handle(GetGridLocalsQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var vm = new LocalVm();

                    var responseModel = await _context.Local
                        .ProjectTo<LocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodLocal)
                        .ToListAsync(cancellationToken);

                    var grid = new GridLocal();

                    var data = responseModel
                        .Select(
                            c =>
                                new LocalDto()
                                {
                                    CodLocal = c.CodLocal,
                                    DscLocal = c.DscLocal,
                                    DscUnidade = c.UnidadeInfraestrutura.Descricao
                                    //NomRazaoSocial = c.NomRazaoSocial,
                                    //NomUnidadeInfraestrutura = ""
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
