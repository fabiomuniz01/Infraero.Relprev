using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Common.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Commands.UpdateAtribuicaoRelato
{
    public partial class UpdateAtribuicaoEnvioRelatoCommand : IRequest<bool>
    {

        public class UpdateAtribuicaoEnvioRelatoCommandHandler : IRequestHandler<UpdateAtribuicaoEnvioRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateAtribuicaoEnvioRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateAtribuicaoEnvioRelatoCommand request, CancellationToken cancellationToken)
            {
                var list = await Queryable.Where(_context.AtribuicaoRelato, x => x.CodRelato == request.CodRelato)
                    .OrderBy(t => t.CodAtribuicaoRelato)
                    .ToListAsync(cancellationToken);

                if (!list.Any())
                {
                    throw new NotFoundException(nameof(Domain.Entities.AtribuicaoRelato), request.CodRelato);
                }

                foreach (var atribuicaoRelato in list)
                {
                    var entity = await _context.AtribuicaoRelato.FindAsync(atribuicaoRelato.CodAtribuicaoRelato);

                    entity.FlagAtivo = true;
                    entity.AlteradoPor = request.AlteradoPor;
                    entity.DataAlteracao = DateTime.Now;
                }

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public int CodRelato { get; set; }

        public string AlteradoPor { get; set; }
    }
}
