using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Perfil.Queries.GetPerfils
{
    public class GetGridPerfilsQuery : IRequest<GridPerfil>
    {
        public class GetGridPerfilsQueryHandler : IRequestHandler<GetGridPerfilsQuery, GridPerfil>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridPerfilsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridPerfil> Handle(GetGridPerfilsQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Perfil
                        .ProjectTo<PerfilDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodPerfil)
                        .ToListAsync(cancellationToken);

                    var grid = new GridPerfil
                    {
                        aaData = responseModel,
                        sEcho = 0,
                        iTotalRecords = responseModel.Count(),
                        recordsFiltered = responseModel.Count(),
                        iTotalDisplayRecords = 1
                    };

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
