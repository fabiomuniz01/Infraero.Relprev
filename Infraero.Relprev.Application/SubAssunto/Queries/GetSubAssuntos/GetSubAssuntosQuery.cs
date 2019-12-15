using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos
{
    public class GetSubAssuntosQuery : IRequest<SubAssuntoVm>
    {
        public class GetSubAssuntosQueryHandler : IRequestHandler<GetSubAssuntosQuery, SubAssuntoVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSubAssuntosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SubAssuntoVm> Handle(GetSubAssuntosQuery request, CancellationToken cancellationToken)
            {
                var vm = new SubAssuntoVm();

                vm.Lists = await _context.SubAssuntos
                    .ProjectTo<SubAssuntoDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodSubAssunto)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
