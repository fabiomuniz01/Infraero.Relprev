using System;
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
    public class GetEmpresaAllQuery : IRequest<List<EmpresaDto>>
    {
        public int Id { get; set; }

        public class GetEmpresaAllQueryHandler : IRequestHandler<GetEmpresaAllQuery, List<EmpresaDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetEmpresaAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<EmpresaDto>> Handle(GetEmpresaAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Empresa
                        .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodEmpresa)
                        .ToListAsync(cancellationToken);

                    
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
