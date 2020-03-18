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

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa
{
    public class ExistVinculoQuery : IRequest<VinculoUnidadeEmpresaDto>
    {
        public int CodVinculoUnidadeEmpresa { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }

        public class GetVinculoUnidadeEmpresaByIdQueryHandler : IRequestHandler<ExistVinculoQuery, VinculoUnidadeEmpresaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVinculoUnidadeEmpresaByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VinculoUnidadeEmpresaDto> Handle(ExistVinculoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.VinculoUnidadeEmpresa
                        .Where(x => x.CodEmpresa == request.CodEmpresa && x.CodUnidadeInfraestrutura == request.CodUnidadeInfraestrutura)
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
