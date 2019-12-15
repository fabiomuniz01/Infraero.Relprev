﻿using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.ResponsavelTecnicos.Queries.GetResponsavelTecnicos
{
    public class GetResponsavelTecnicoByIdQuery : IRequest<ResponsavelTecnicoDto>
    {
        public int Id { get; set; }

        public class GetResponsavelTecnicoByIdQueryHandler : IRequestHandler<GetResponsavelTecnicoByIdQuery, ResponsavelTecnicoDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetResponsavelTecnicoByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ResponsavelTecnicoDto> Handle(GetResponsavelTecnicoByIdQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.ResponsavelTecnicos
                        .Where(x=>x.CodResponsavelTecnico==request.Id)
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodResponsavelTecnico)
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
