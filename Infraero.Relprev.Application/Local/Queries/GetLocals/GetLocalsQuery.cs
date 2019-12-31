using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class GetLocalsQuery : IRequest<LocalVm>
    {
        public class GetLocalsQueryHandler : IRequestHandler<GetLocalsQuery, LocalVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetLocalsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<LocalVm> Handle(GetLocalsQuery request, CancellationToken cancellationToken)
            {
                var vm = new LocalVm();

                vm.Lists = await _context.Local
                    .ProjectTo<LocalDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodLocal)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
