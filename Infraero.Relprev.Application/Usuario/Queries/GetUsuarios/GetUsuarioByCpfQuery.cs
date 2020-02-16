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
    public class GetUsuarioByCpfQuery : IRequest<UsuarioDto>
    {
        public int Id { get; set; }

        public class GetUsuarioByCpfQueryHandler : IRequestHandler<GetUsuarioByCpfQuery, UsuarioDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUsuarioByCpfQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<UsuarioDto> Handle(GetUsuarioByCpfQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Usuario
                        .Where(x=>x.NumCpf==request.Cpf)
                        .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
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

        public string Cpf { get; set; }
    }
}
