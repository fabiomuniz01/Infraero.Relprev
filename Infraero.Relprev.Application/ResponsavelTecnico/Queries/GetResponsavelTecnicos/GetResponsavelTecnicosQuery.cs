using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos
{
    public class GetResponsavelTecnicosQuery : IRequest<ResponsavelTecnicoVm>
    {
        public class GetResponsavelTecnicosQueryHandler : IRequestHandler<GetResponsavelTecnicosQuery, ResponsavelTecnicoVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetResponsavelTecnicosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ResponsavelTecnicoVm> Handle(GetResponsavelTecnicosQuery request, CancellationToken cancellationToken)
            {
                var vm = new ResponsavelTecnicoVm();

                vm.Lists = await _context.ResponsavelTecnico
                    .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodResponsavelTecnico)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
