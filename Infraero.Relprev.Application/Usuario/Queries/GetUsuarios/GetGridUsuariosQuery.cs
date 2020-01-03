using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class GetGridUsuariosQuery : IRequest<GridUsuario>
    {
        public class GetGridUsuariosQueryHandler : IRequestHandler<GetGridUsuariosQuery, GridUsuario>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridUsuariosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridUsuario> Handle(GetGridUsuariosQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Usuario
                        .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodUsuario)
                        .ToListAsync(cancellationToken);

                    var grid = new GridUsuario
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
