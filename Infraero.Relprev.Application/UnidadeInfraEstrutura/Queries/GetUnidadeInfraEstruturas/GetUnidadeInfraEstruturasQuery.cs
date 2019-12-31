using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
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

                vm.Lists = await _context.UnidadeInfraestrutura
                    .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodUnidadeInfraestrutura)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
