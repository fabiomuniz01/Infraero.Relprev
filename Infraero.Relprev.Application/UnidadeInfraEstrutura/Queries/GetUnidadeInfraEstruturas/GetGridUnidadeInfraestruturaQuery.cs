﻿using System;
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
    public class GetGridUnidadeInfraestruturaQuery : IRequest<GridUnidadeInfraEstrutura>
    {
        public class GetGridUnidadeInfraestruturasQueryHandler : IRequestHandler<GetGridUnidadeInfraestruturaQuery, GridUnidadeInfraEstrutura>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridUnidadeInfraestruturasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridUnidadeInfraEstrutura> Handle(GetGridUnidadeInfraestruturaQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.UnidadeInfraestrutura
                        .ProjectTo<UnidadeInfraEstruturaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodUnidadeInfraestrutura)
                        .ToListAsync(cancellationToken);

                    var grid = new GridUnidadeInfraEstrutura();

                    var data = responseModel
                        .Select(
                            c =>
                                new UnidadeInfraEstruturaDto()
                                {
                                   CodUnidade = c.CodUnidade,
                                   CodUnidadeInfraestrutura = c.CodUnidadeInfraestrutura,
                                   NomUnidadeÌnfraestrutura = c.NomUnidadeÌnfraestrutura,
                                   Descricao = c.Descricao,
                                   DtFimVigencia = c.DtFimVigencia,
                                   DtIniVigencia = c.DtIniVigencia,
                                   Endereco = c.Endereco,
                                   Sigla = c.Sigla
                                });

                    grid.aaData = data;
                    grid.sEcho = 0;
                    grid.iTotalRecords = data.Count();
                    grid.recordsFiltered = data.Count();
                    grid.iTotalDisplayRecords = 1;
                    return grid;
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
