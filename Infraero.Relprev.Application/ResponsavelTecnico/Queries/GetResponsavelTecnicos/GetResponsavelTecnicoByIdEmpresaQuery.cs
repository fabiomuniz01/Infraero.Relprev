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

namespace Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos
{
    public class GetResponsavelTecnicoByIdEmpresaQuery : IRequest<List<ResponsavelTecnicoDto>>
    {
        public int Id { get; set; }
        public bool GestorSgSO { get; set; }

        public class GetResponsavelTecnicoByIdEmpresaQueryQueryHandler : IRequestHandler<GetResponsavelTecnicoByIdEmpresaQuery, List<ResponsavelTecnicoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetResponsavelTecnicoByIdEmpresaQueryQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<ResponsavelTecnicoDto>> Handle(GetResponsavelTecnicoByIdEmpresaQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ResponsavelTecnico
                        .Where(r=>r.Empresa.CodEmpresa==request.Id && r.FlagGestorSgso==false)
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.NomResponsavelTecnico)
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
