using System;
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
    public class GetResponsavelTecnicoByCpfQuery : IRequest<ResponsavelTecnicoDto>
    {
        public int Id { get; set; }
        public string Cpf { get; set; }

        public class GetResponsavelTecnicoByCpfQueryHandler : IRequestHandler<GetResponsavelTecnicoByCpfQuery, ResponsavelTecnicoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetResponsavelTecnicoByCpfQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ResponsavelTecnicoDto> Handle(GetResponsavelTecnicoByCpfQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ResponsavelTecnico
                        .Where(x=>x.NumCpf==request.Cpf)
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodResponsavelTecnico)
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
