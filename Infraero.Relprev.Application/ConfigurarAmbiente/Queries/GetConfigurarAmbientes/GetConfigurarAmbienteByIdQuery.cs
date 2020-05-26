using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes
{
    public class GetConfigurarAmbienteByIdQuery : IRequest<ConfigurarAmbienteDto>
    {
        public int Id { get; set; }

        public class GetConfigurarAmbienteByIdQueryHandler : IRequestHandler<GetConfigurarAmbienteByIdQuery, ConfigurarAmbienteDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetConfigurarAmbienteByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ConfigurarAmbienteDto> Handle(GetConfigurarAmbienteByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await Queryable.Where(_context.ConfigurarAmbiente, x=>x.CodConfigurarAmbiente==request.Id)
                        .ProjectTo<ConfigurarAmbienteDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodConfigurarAmbiente)
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
