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
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    FlagGestorSgso = false,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now,
                    FlagAtivo = true
                };

                _context.ResponsavelTecnico.Add(entity);
                await _context.SaveChangesAsync(cancellationToken);

                foreach (var item in request.arrEmpresa)
                {
                    var entityVinculo = new Domain.Entities.VinculoResponsavelEmpresa
                    {
                        CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                        CodEmpresa = Convert.ToInt32(item),
                        CodResponsavelTecnico = entity.CodResponsavelTecnico,
                        CriadoPor = request.CriadoPor,
                        DataCriacao = DateTime.Now
                    };

                    _context.VinculoResponsavelEmpresa.Add(entityVinculo);
                }


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
