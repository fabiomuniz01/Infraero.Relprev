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
        public string Endereco { get; set; }
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
                    CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
                    CodUnidade = request.CodUnidade,
                    Sigla = request.Sigla,
                    Descricao = request.Descricao,
                    Endereco = request.Endereco,
                    DtIniVigencia = request.DtIniVigencia,
                    DtFimVigencia = request.DtFimVigencia,
                    DataCriacao = DateTime.Now,
                    CriadoPor = request.CriadoPor
                };

                _context.UnidadeInfraestruturas.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodUnidadeInfraestrutura;
            }
        }

        public string CriadoPor { get; set; }
    }
}
