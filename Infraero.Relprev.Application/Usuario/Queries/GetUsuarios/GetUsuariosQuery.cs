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
    public class GetUsuariosQuery : IRequest<List<UsuarioDto>>
    {
        public class GetUsuariosQueryHandler : IRequestHandler<GetUsuariosQuery, List<UsuarioDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUsuariosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<UsuarioDto>> Handle(GetUsuariosQuery request, CancellationToken cancellationToken)
            {
                var vm = new UsuarioDto();

                return await _context.Usuario
                    .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodUsuario)
                    .ToListAsync(cancellationToken);

            }
        }
    }
}
