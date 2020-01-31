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
        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }

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
                    NomUnidade = request.NomUnidade,
                    DtIniVigencia = request.DtIniVigencia,
                    DtFimVigencia = request.DtFimVigencia,
                    CriadoPor = request.CriadoPor
                };

                _context.UnidadeInfraestrutura.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodUnidadeInfraestrutura;
            }
        }

        public string NomUnidade { get; set; }

        public string CriadoPor { get; set; }
        public string NomeUnidade { get; set; }
    }
}
