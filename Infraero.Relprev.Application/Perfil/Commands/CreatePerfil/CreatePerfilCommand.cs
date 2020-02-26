using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Perfil.Commands.CreatePerfil
{
    public class CreatePerfilCommand : IRequest<long>
    {
        public class CreatePerfilCommandHandler : IRequestHandler<CreatePerfilCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreatePerfilCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreatePerfilCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Perfil
                {
                    NomPerfil = request.NomPerfil,
                    DscPerfil = request.DscPerfil,
                    FlgAtivo = request.FlgAtivo
                };

                _context.Perfil.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodPerfil;
            }
        }

        public bool FlgAtivo { get; set; }

        public string DscPerfil { get; set; }

        public string NomPerfil { get; set; }
        public ListDictionary ListClaim { get; set; }
    }
}
