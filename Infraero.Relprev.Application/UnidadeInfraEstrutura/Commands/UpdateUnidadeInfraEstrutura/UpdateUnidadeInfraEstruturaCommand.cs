using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura
{
    public partial class UpdateUnidadeInfraEstruturaCommand : IRequest<bool>
    {
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodUnidade { get; set; }
        public string Sigla { get; set; }

        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }

        public class UpdateAssuntoCommandHandler : IRequestHandler<UpdateUnidadeInfraEstruturaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateUnidadeInfraEstruturaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.UnidadeInfraestrutura.FindAsync(request.CodUnidadeInfraestrutura);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(UnidadeInfraEstrutura), request.CodUnidadeInfraestrutura);
                }

                entity.CodUnidade = request.CodUnidade;
                entity.Sigla = request.Sigla;
                entity.Descricao = request.Descricao;
                entity.Endereco = request.Endereco;
                entity.DtIniVigencia = request.DtIniVigencia;
                entity.DtFimVigencia = request.DtFimVigencia;
                entity.DataAlteracao = DateTime.Now;
                entity.AlteradoPor = request.AlteradorPor;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string AlteradorPor { get; set; }
    }
}
