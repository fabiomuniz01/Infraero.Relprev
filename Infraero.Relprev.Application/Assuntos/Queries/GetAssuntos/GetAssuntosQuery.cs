using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos
{
    public class GetAssuntosQuery : IRequest<AssuntoVm>
    {
        public class GetAssuntosQueryHandler : IRequestHandler<GetAssuntosQuery, AssuntoVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAssuntosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<AssuntoVm> Handle(GetAssuntosQuery request, CancellationToken cancellationToken)
            {
                var vm = new AssuntoVm();

                vm.Lists = await _context.Assuntos
                    .ProjectTo<AssuntoDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodAssunto)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
