﻿using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Domain.Enums;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;

namespace Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuarioDetail
{
    public class UpdateUsuarioDetailCommand : IRequest
    {
        public UsuarioDto UsuarioDto { get; set; }

        public class UpdateUsuarioDetailCommandHandler : IRequestHandler<UpdateUsuarioDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateUsuarioDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateUsuarioDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Usuarios.FindAsync(request.UsuarioDto.CodUsuario);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Usuario), request.UsuarioDto.CodUsuario);
                }

                entity.DscLogin = request.UsuarioDto.NomRazaoSocial;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
