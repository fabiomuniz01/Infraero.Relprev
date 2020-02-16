using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using MediatR;

namespace Infraero.Relprev.Application.Usuario.Commands.UpdateUsuarioDetail
{
    public class UpdateUsuarioDetailCommand : IRequest
    {

        public class UpdateUsuarioDetailCommandHandler : IRequestHandler<UpdateUsuarioDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateUsuarioDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateUsuarioDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Usuario.FindAsync(request.CodUsuario);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Usuario), request.CodUsuario);
                }

                entity.NomUsuario = request.NomUsuario;
                entity.NumCpf = request.NumCpf;
                entity.EndEmail = request.EndEmail;
                entity.NumTelefone = request.NumTelefone;
                entity.CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura;
                entity.CodPerfil = request.CodPerfil;
                entity.CodEmpresa = request.CodEmpresa;
                entity.CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura;
                entity.CodPerfil = request.CodPerfil;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }

        public int CodEmpresa { get; set; }

        public int CodUsuario { get; set; }

        public string CodPerfil { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string NumTelefone { get; set; }

        public string EndEmail { get; set; }

        public string NumCpf { get; set; }

        public string NomUsuario { get; set; }
    }
}
