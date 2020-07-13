using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario
{
    public partial class UpdateUsuarioCommand : IRequest<bool>
    {
        

        public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateUsuarioCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
            {
                var entity =  _context.Usuario.Where(x=>x.CodUsuarioLogin == request.Id).FirstOrDefault();

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Usuario), request.Id);
                }

                entity.NomUsuario = request.NomUsuario;
                entity.NumTelefone = request.NumTelefone;
                entity.CodEmpresa = request.CodEmpresa;
                entity.CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura;
                entity.CodPerfil = request.CodPerfil;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                entity.NomPerfil = request.NomPerfil;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string Id { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string Email { get; set; }
        public string AlteradoPor { get; set; }
        public string UserName { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string CodPerfil { get; set; }
        public string NomPerfil { get; set; }
    }
}
