using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresas
{
    public class GetVinculoUnidadeEmpresaByIdQuery : IRequest<VinculoUnidadeEmpresaDto>
    {
        public int CodVinculoUnidadeEmpresa { get; set; }

        public class GetVinculoUnidadeEmpresaByIdQueryHandler : IRequestHandler<GetVinculoUnidadeEmpresaByIdQuery, VinculoUnidadeEmpresaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVinculoUnidadeEmpresaByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VinculoUnidadeEmpresaDto> Handle(GetVinculoUnidadeEmpresaByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoUnidadeEmpresa
                        .Where(x => x.CodVinculoUnidadeEmpresa == request.CodVinculoUnidadeEmpresa)
                        .ProjectTo<VinculoUnidadeEmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodEmpresa)
                        .FirstOrDefaultAsync(cancellationToken);


                    return responseModel;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
        }

    }
}
