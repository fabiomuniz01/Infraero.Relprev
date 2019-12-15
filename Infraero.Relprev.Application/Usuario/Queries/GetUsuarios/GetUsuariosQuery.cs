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
    public class GetUsuariosQuery : IRequest<UsuarioVm>
    {
        public class GetUsuariosQueryHandler : IRequestHandler<GetUsuariosQuery, UsuarioVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUsuariosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UsuarioVm> Handle(GetUsuariosQuery request, CancellationToken cancellationToken)
            {
                var vm = new UsuarioVm();

                vm.Lists = await _context.Usuarios
                    .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodUsuario)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
