using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato
{
    public class CreateAtribuicaoRelatoCommand : IRequest<long>
    {
        public class CreateAtribuicaoRelatoCommandHandler : IRequestHandler<CreateAtribuicaoRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateAtribuicaoRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateAtribuicaoRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.AtribuicaoRelato
                {
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.AtribuicaoRelato.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodAtribuicaoRelato;
            }
        }

        public string CriadoPor { get; set; }

        public int CodAtribuicaoRelato { get; set; }
        public string DscAtribuicaoRelato { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
    }
}
