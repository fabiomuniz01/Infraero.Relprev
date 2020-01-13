using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Empresa.Queries.GetEmpresas
{
    public class GetEmpresasQuery : IRequest<List<EmpresaDto>>
    {
        public class GetEmpresasQueryHandler : IRequestHandler<GetEmpresasQuery, List<EmpresaDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetEmpresasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<EmpresaDto>> Handle(GetEmpresasQuery request, CancellationToken cancellationToken)
            {
                return await _context.Empresa
                    .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.CodEmpresa)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
