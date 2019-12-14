﻿using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Empresas.Queries.GetEmpresas
{
    public class GetGridEmpresasQuery : IRequest<GridEmpresa>
    {
        public class GetGridEmpresasQueryHandler : IRequestHandler<GetGridEmpresasQuery, GridEmpresa>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridEmpresasQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridEmpresa> Handle(GetGridEmpresasQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var vm = new EmpresaVm();

                    var responseModel = await _context.Empresas
                        .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodEmpresa)
                        .ToListAsync(cancellationToken);

                    var grid = new GridEmpresa();

                    var data = responseModel
                        .Select(
                            c =>
                                new EmpresaDto()
                                {
                                    CodEmpresa = c.CodEmpresa,
                                    NumCnpj = c.NumCnpj,
                                    NumTelefone = c.NumTelefone,
                                    NomRazaoSocial = c.NomRazaoSocial,
                                    NomUnidadeInfraestrutura = ""
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
