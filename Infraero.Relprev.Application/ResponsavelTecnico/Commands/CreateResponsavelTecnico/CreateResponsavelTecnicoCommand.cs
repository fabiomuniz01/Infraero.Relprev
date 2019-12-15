using System;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.ResponsavelTecnicos.Commands.CreateResponsavelTecnico
{
    public class CreateResponsavelTecnicoCommand : IRequest<long>
    {

        public class CreateResponsavelTecnicoCommandHandler : IRequestHandler<CreateResponsavelTecnicoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateResponsavelTecnicoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateResponsavelTecnicoCommand request, CancellationToken cancellationToken)
            {
                var entity = new ResponsavelTecnico
                {
                    NomResponsavelTecnico = request.NomResponsavelTecnico,
                    NumCpf = request.NumCpf,
                    NumTelefone = request.NumTelefone,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.ResponsavelTecnicos.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodResponsavelTecnico;
            }
        }
        public int Id { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string DscLogin { get; set; }
        public string DscSenha { get; set; }
        public DateTime DthRegistro { get; set; }
        public string EndEmail { get; set; }
        public int QtdTentativasIncorretas { get; set; }
        public string FlgPrimeiroAcesso { get; set; }
        public string FlgResponsavelTecnicoBloqueado { get; set; }
        public string CriadoPor { get; set; }

        
    }
}
