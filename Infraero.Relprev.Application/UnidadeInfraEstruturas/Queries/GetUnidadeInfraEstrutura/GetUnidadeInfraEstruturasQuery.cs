using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.UnidadeInfraestruturas.Queries.GetUnidadeInfraestruturas
{
    public class GetUnidadeInfraEstruturasQuery : IRequest<UnidadeInfraEstruturaVm>
    {
        public class GetUnidadeInfraestruturasQueryHandler : IRequestHandler<GetUnidadeInfraEstruturasQuery, UnidadeInfraEstruturaVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUnidadeInfraestruturasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UnidadeInfraEstruturaVm> Handle(GetUnidadeInfraEstruturasQuery request, CancellationToken cancellationToken)
            {
                var vm = new UnidadeInfraEstruturaVm();

                vm.Lists = await _context.UnidadeInfraestruturas
                    .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodUnidadeInfraestrutura)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
