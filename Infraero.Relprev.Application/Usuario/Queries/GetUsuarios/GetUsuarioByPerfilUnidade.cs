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

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class GetUsuarioByPerfilUnidadeQuery : IRequest<List<UsuarioDto>>
    {

        public class GetUsuarioByPerfilUnidadeQueryHandler : IRequestHandler<GetUsuarioByPerfilUnidadeQuery, List<UsuarioDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUsuarioByPerfilUnidadeQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<UsuarioDto>> Handle(GetUsuarioByPerfilUnidadeQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Usuario
                        .Where(x => x.CodPerfil == request.CodPerfil && x.CodUnidadeInfraestrutura == request.CodUnidadeInfraestrutura)
                        .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodUsuario)
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

        public string CodPerfil { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }
    }
}
