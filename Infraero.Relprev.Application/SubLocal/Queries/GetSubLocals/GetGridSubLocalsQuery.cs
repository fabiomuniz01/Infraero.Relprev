using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals
{
    public class GetGridSubLocalsQuery : IRequest<GridSubLocal>
    {
        public class GetGridSubLocalsQueryHandler : IRequestHandler<GetGridSubLocalsQuery, GridSubLocal>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridSubLocalsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridSubLocal> Handle(GetGridSubLocalsQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var vm = new SubLocalVm();

                    var responseModel = await _context.SubLocals
                        .ProjectTo<SubLocalDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodSubLocal)
                        .ToListAsync(cancellationToken);

                    var grid = new GridSubLocal();

                    var data = responseModel
                        .Select(
                            c =>
                                new SubLocalDto()
                                {
                                    CodSubLocal = c.CodSubLocal,
                                    //NumCnpj = c.NumCnpj,
                                    //NumTelefone = c.NumTelefone,
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
