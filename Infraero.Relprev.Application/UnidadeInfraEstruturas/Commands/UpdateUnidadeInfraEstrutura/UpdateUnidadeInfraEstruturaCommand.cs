using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateAssunto
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
                var entity = await _context.UnidadeInfraestruturas.FindAsync(request.CodUnidadeInfraestrutura);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Assunto), request.CodUnidadeInfraestrutura);
                }

                entity.CodUnidade = request.CodUnidade;
                entity.CodUnidadeInfraestrutura= request.CodUnidadeInfraestrutura;
                entity.Descricao = request.Descricao;
                entity.Endereco = request.Endereco;
                entity.DtIniVigencia = request.DtIniVigencia;
                entity.DtFimVigencia = request.DtFimVigencia;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

    }
}
