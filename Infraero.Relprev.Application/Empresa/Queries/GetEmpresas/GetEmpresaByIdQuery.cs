using System;
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
    public class GetEmpresaByIdQuery : IRequest<EmpresaDto>
    {
        public int Id { get; set; }

        public class GetEmpresaByIdQueryHandler : IRequestHandler<GetEmpresaByIdQuery, EmpresaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetEmpresaByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<EmpresaDto> Handle(GetEmpresaByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Empresas
                        .Where(x=>x.CodEmpresa==request.Id)
                        .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
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
