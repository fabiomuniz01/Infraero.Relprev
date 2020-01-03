using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Usuario.Commands.CreateUsuario
{
    public class CreateUsuarioCommand : IRequest<long>
    {

        public class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateUsuarioCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Usuario
                {
                    NomUsuario = request.NomUsuario,
                    NumCpf = request.NumCpf,
                    EndEmail = request.EndEmail, 
                    NumTelefone = request.NumTelefone,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now,
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura
                };

                _context.Usuario.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodUsuario;
            }
        }
        public int Id { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; } 
        public string DscLogin { get; set; }
        public string DscSenha { get; set; }
        public DateTime DthRegistro { get; set; }
        public DateTime DataCriacao { get; set; }
        public string EndEmail { get; set; }
        public int QtdTentativasIncorretas { get; set; }
        public string FlgPrimeiroAcesso { get; set; }
        public string FlgUsuarioBloqueado { get; set; }
        public string CriadoPor { get; set; }

        public int CodUnidadeInfraestrutura { get; set; } 
    }
}
