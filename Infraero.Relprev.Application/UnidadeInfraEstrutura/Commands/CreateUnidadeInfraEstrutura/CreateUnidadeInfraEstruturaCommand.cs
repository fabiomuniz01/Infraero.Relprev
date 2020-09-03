using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura
{
    public class CreateUnidadeInfraEstruturaCommand : IRequest<long>
    {

        public int CodUnidadeInfraestrutura { get; set; }
        public string CodUnidade { get; set; }
        public string Sigla { get; set; }

        public string Descricao { get; set; }
        public string DtIniVigencia { get; set; }
        public string DtFimVigencia { get; set; }

        public class CreateUnidadeInfraestruturaCommandHandler : IRequestHandler<CreateUnidadeInfraEstruturaCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateUnidadeInfraestruturaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateUnidadeInfraEstruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = new UnidadeInfraestrutura
                {
                    CodUnidade = request.CodUnidade,
                    Sigla = request.Sigla,
                    Descricao = request.Descricao,
                    NomUnidadeÌnfraestrutura = request.NomUnidadeÌnfraestrutura,
                    Endereco = request.Endereco,
                    DtIniVigencia = Convert.ToDateTime(request.DtIniVigencia),
                    DtFimVigencia = Convert.ToDateTime(request.DtFimVigencia),
                    CriadoPor = request.CriadoPor,
                    FlagAtivo = true
                };

                _context.UnidadeInfraestrutura.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodUnidadeInfraestrutura;
            }
        }

        public string Endereco { get; set; }

        public string NomUnidadeÌnfraestrutura { get; set; }

        public string CriadoPor { get; set; }
    }
}
