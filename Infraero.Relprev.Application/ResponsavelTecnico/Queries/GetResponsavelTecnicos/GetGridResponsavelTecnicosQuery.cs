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
    public class GetGridResponsavelTecnicosQuery : IRequest<GridResponsavelTecnico>
    {
        public class GetGridResponsavelTecnicosQueryHandler : IRequestHandler<GetGridResponsavelTecnicosQuery, GridResponsavelTecnico>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetGridResponsavelTecnicosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GridResponsavelTecnico> Handle(GetGridResponsavelTecnicosQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ResponsavelTecnico
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodResponsavelTecnico)
                        .ToListAsync(cancellationToken);

                    var grid = new GridResponsavelTecnico();

                    var data = responseModel.Select(c => new ResponsavelTecnicoDto
                    {
                        CodResponsavelTecnico = c.CodResponsavelTecnico, NomResponsavelTecnico=c.NomResponsavelTecnico,
                        NumCpf = c.NumCpf, EndEmail=c.EndEmail, DscEmpresa = c.Empresa.NomRazaoSocial, NumTelefone = c.NumTelefone
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
