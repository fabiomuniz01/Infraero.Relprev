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
                    Email = request.Email, 
                    NomPerfil = request.NomPerfil,
                    NumTelefone = request.NumTelefone,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now,
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    CodEmpresa = request.CodEmpresa,
                    CodPerfil = request.CodPerfil,
                    CodUsuarioLogin = request.Id
                };

                _context.Usuario.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodUsuario;
            }
        }

        public string NomPerfil { get; set; }

        public string Id { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; } 
        public string DthRegistro { get; set; }
        public string CriadoPor { get; set; }
        public string DateRegistered { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string CodPerfil { get; set; }
    }
}
