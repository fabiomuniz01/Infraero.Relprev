using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios
{
    public class GetUsuariosQuery : IRequest<UsuariosVm>
    {
        public class GetUsuariosQueryHandler : IRequestHandler<GetUsuariosQuery, UsuariosVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUsuariosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UsuariosVm> Handle(GetUsuariosQuery request, CancellationToken cancellationToken)
            {
                var vm = new UsuariosVm();

                vm.Lists = await _context.Usuarios
                    .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.Title)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
