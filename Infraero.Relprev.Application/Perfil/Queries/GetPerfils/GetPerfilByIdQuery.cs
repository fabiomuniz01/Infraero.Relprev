using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Perfil.Queries.GetPerfils
{
    public class GetPerfilByIdQuery : IRequest<PerfilDto>
    {
        public int Id { get; set; }

        public class GetPerfilByIdQueryHandler : IRequestHandler<GetPerfilByIdQuery, PerfilDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetPerfilByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<PerfilDto> Handle(GetPerfilByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await Queryable.Where<Domain.Entities.Perfil>(_context.Perfil, x=>x.CodPerfil==request.Id)
                        .ProjectTo<PerfilDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodPerfil)
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
