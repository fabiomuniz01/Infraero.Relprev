﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto
{
    public class CreateSubAssuntoCommand : IRequest<long>
    {
        public int CodSubAssunto { get; set; }
        public string DscSubAssunto { get; set; }
        public int CodAssunto { get; set; }

        public string CriadoPor { get; set; }

        public class CreateSubAssuntoCommandHandler : IRequestHandler<CreateSubAssuntoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateSubAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateSubAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.SubAssunto
                { 
                    CodAssunto = request.CodAssunto,
                    DscSubAssunto = request.DscSubAssunto,
                    CodSubAssunto = request.CodSubAssunto,
                };

                _context.SubAssunto.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodSubAssunto;
            }
        }

        
    }
}
