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
                    var vm = new UsuarioVm();

                    var responseModel = await _context.Usuarios
                        .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodUsuario)
                        .ToListAsync(cancellationToken);

                    var grid = new GridUsuario();

                    var data = responseModel
                        .Select(
                            c =>
                                new UsuarioDto()
                                {
                                    CodUsuario = c.CodUsuario,
                                    NumCnpj = c.NumCnpj,
                                    NumTelefone = c.NumTelefone,
                                    NomRazaoSocial = c.NomRazaoSocial,
                                    NomUnidadeInfraestrutura = ""
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
