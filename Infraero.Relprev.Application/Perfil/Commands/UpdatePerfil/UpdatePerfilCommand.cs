using System;
using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil
{
    public partial class UpdatePerfilCommand : IRequest<bool>
    {

        public class UpdatePerfilCommandHandler : IRequestHandler<UpdatePerfilCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdatePerfilCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdatePerfilCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Perfil.FindAsync(request.CodPerfil);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Perfil), request.CodPerfil);
                }

                entity.NomPerfil = request.NomPerfil;
                entity.DscPerfil = request.DscPerfil;
                entity.FlgAtivo = request.FlgAtivo;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public bool FlgAtivo { get; set; }

        public string DscPerfil { get; set; }

        public string NomPerfil { get; set; }

        public string CodPerfil { get; set; }
        public ListDictionary ListClaim { get; set; }
    }
}
