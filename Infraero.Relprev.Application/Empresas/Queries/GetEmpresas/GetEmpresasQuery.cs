using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Empresas.Queries.GetEmpresas
{
    public class GetEmpresasQuery : IRequest<EmpresaVm>
    {
        public class GetEmpresasQueryHandler : IRequestHandler<GetEmpresasQuery, EmpresaVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetEmpresasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<EmpresaVm> Handle(GetEmpresasQuery request, CancellationToken cancellationToken)
            {
                var vm = new EmpresaVm();

                vm.Lists = await _context.Empresas
                    .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodEmpresa)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
