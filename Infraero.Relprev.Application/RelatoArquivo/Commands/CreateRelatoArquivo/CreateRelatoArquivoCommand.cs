using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo
{
    public class CreateRelatoArquivoCommand : IRequest<long>
    {
        

        public class CreateRelatoArquivoCommandHandler : IRequestHandler<CreateRelatoArquivoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateRelatoArquivoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateRelatoArquivoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.RelatoArquivo
                {
                    CodRelato = request.CodRelato,
                    NomeArquivo = request.NomeArquivo,
                    Arquivo = request.Arquivo,
                    Caminho =request.Caminho,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                    
                    
                };

                _context.RelatoArquivo.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodRelatoArquivo;
            }
        }
        public int CodRelato { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }
        public string CriadoPor { get; set; }

       
    }
}
