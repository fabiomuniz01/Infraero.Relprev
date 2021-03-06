﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Assunto.Queries.GetAssuntos
{
    public class GetLocalAllQuery : IRequest<List<AssuntoDto>>
    {
        public class GetAssuntoAllQueryHandler : IRequestHandler<GetLocalAllQuery, List<AssuntoDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAssuntoAllQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<AssuntoDto>> Handle(GetLocalAllQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseModel = await _context.Assunto
                        .ProjectTo<AssuntoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodAssunto)
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
