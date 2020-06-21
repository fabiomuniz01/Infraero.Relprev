using System;
using System.Threading;
using System.Threading.Tasks;
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
                    CodEmpresa = request.CodEmpresa,
                    DataCriacao = DateTime.Now
                };

                _context.ResponsavelTecnico.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodResponsavelTecnico;
            }
        }

        public string CriadoPor { get; set; }

        public string EndEmail { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NumDocumento { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string[] arrEmpresa { get; set; }
    }
}
