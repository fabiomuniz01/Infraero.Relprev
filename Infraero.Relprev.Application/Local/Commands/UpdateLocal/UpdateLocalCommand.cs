﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Local.Commands.UpdateLocal
{
    public partial class UpdateLocalCommand : IRequest<bool>
    {

        public class UpdateLocalCommandHandler : IRequestHandler<UpdateLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Locals.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Local), request.Id);
                }

                //entity.NomRazaoSocial = request.NomRazaoSocial;
                //entity.NumCnpj = request.NumCnpj;
                //entity.NumTelefone = request.NumTelefone;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string AlteradoPor { get; set; }

        public int Id { get; set; }
    }
}
