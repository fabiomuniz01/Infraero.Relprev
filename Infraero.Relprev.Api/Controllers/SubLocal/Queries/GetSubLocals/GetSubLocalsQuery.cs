using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Api.Controllers.SubLocal.Queries.GetSubLocals
{
    public class GetSubLocalsQuery : IRequest<SubLocalVm>
    {
        public class GetSubLocalsQueryHandler : IRequestHandler<GetSubLocalsQuery, SubLocalVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubLocalsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SubLocalVm> Handle(GetSubLocalsQuery request, CancellationToken cancellationToken)
            {
                var vm = new SubLocalVm();

                vm.Lists = await _context.SubLocals
                    .ProjectTo<SubLocalDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodSubLocal)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
