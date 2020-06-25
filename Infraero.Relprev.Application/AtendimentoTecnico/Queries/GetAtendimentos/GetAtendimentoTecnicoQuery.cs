using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico
{
    public class GetAtendimentoTecnicoQuery : IRequest<List<RelatoDto>>
    {
        public class GetAtendimentoTecnicoHandler : IRequestHandler<GetAtendimentoTecnicoQuery, List<RelatoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAtendimentoTecnicoHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<RelatoDto>> Handle(GetAtendimentoTecnicoQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    List<RelatoDto> ObjRelatos = new List<RelatoDto>();

                    var atribuidos = await _context.AtribuicaoRelato
                        .Where(r => r.CodResponsavelTecnico == Convert.ToInt32(request.AtendimentoTecnico.CodResponsavelTecnico))
                        .ProjectTo<AtribuicaoRelatoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAtribuicaoRelato)
                        .ToListAsync(cancellationToken);

                    foreach (var item in atribuidos)
                    {
                        ObjRelatos.Add(
                            await _context.Relato
                            .Where(x => x.CodRelato == item.CodRelato)
                            .ProjectTo<RelatoDto>(_mapper.ConfigurationProvider)
                            .OrderBy(t => t.CodRelato)
                            .FirstOrDefaultAsync(cancellationToken));
                    }


                    return ObjRelatos;


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
        public AtendimentoTecnicoDto.AtendimentoTecnicoRequest AtendimentoTecnico { get; set; }

    }
}
