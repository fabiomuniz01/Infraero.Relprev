using System;
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
                var entity = await _context.Usuarios.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Domain.Entities.Usuario), request.Id);
                }

                entity.NomUsuario = request.NomUsuario;
                entity.NumCpf = request.NumCpf;
                entity.NumTelefone = request.NumTelefone;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public int Id { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string DscLogin { get; set; }
        public string DscSenha { get; set; }
        public DateTime DthRegistro { get; set; }
        public string EndEmail { get; set; }
        public int QtdTentativasIncorretas { get; set; }
        public string FlgPrimeiroAcesso { get; set; }
        public string FlgUsuarioBloqueado { get; set; }
        public string AlteradoPor { get; set; }
    }
}
