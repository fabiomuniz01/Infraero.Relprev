using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class GetUnidadeInfraEstruturaByIdQuery : IRequest<UnidadeInfraEstruturaDto>
    {
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodUnidade { get; set; }
        public string Sigla { get; set; }

        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }

        public class GetUnidadeInfraestruturaByIdQueryHandler : IRequestHandler<GetUnidadeInfraEstruturaByIdQuery, UnidadeInfraEstruturaDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUnidadeInfraestruturaByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UnidadeInfraEstruturaDto> Handle(GetUnidadeInfraEstruturaByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.UnidadeInfraestrutura
                        .Where(x=>x.CodUnidadeInfraestrutura==request.CodUnidadeInfraestrutura)
                        .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodUnidadeInfraestrutura)
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
