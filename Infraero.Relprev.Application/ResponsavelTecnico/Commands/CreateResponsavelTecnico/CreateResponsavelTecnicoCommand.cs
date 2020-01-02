using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico
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
                var entity = new Domain.Entities.ResponsavelTecnico
                {
                    NomResponsavelTecnico = request.NomResponsavelTecnico,
                    NumCpf = request.NumCpf,
                    EndEmail = request.EndEmail,
                    NumTelefone = request.NumTelefone,
                    NumDocumento = request.NumDocumento,
                    CriadoPor = request.CriadoPor,
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    CodEmpresaResponsavelTecnico = request.CodEmpresaResponsavelTecnico,
                    DataCriacao = DateTime.Now
                };

                _context.ResponsavelTecnico.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodResponsavelTecnico;
            }
        }
        public int Id { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NumDocumento { get; set; }
        public string DscLogin { get; set; }
        public string DscSenha { get; set; }
        public DateTime DthRegistro { get; set; }
        public string EndEmail { get; set; }
        public int QtdTentativasIncorretas { get; set; }
        public string FlgPrimeiroAcesso { get; set; }
        public string FlgResponsavelTecnicoBloqueado { get; set; }
        public string CriadoPor { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresaResponsavelTecnico { get; set; }


    }
}
