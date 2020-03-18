using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.Arquivo.Commands.CreateArquivo
{
    public class CreateArquivoCommand : IRequest<long>
    {
        

        public class CreateArquivoCommandHandler : IRequestHandler<CreateArquivoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateArquivoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateArquivoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Arquivo
                {
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.Arquivo.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodArquivo;
            }
        }

        public string CriadoPor { get; set; }
        
    }
}
