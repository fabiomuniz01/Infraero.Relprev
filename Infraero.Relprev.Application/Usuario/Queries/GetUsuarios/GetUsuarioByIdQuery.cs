using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class GetUsuarioByIdQuery : IRequest<UsuarioDto>
    {
        public string Id { get; set; }

        public class GetUsuarioByIdQueryHandler : IRequestHandler<GetUsuarioByIdQuery, UsuarioDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUsuarioByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UsuarioDto> Handle(GetUsuarioByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Usuario
                        .Where(x => x.CodUsuarioLogin == request.Id)
                        .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
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
