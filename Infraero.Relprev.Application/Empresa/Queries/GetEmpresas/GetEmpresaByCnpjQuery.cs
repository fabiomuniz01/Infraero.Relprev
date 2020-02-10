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
    public class GetEmpresaByCnpjQuery : IRequest<EmpresaDto>
    {
        public int Id { get; set; }

        public class GetEmpresaByCnpjQueryHandler : IRequestHandler<GetEmpresaByCnpjQuery, EmpresaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetEmpresaByCnpjQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<EmpresaDto> Handle(GetEmpresaByCnpjQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Empresa
                        .Where(x=>x.NumCnpj==request.Cnpj)
                        .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
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

        public string Cnpj { get; set; }
    }
}
