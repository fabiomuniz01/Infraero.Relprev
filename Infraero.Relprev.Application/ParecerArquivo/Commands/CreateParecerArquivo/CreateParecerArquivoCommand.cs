using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.ParecerArquivo.Commands.CreateParecerArquivo
{
    public class CreateParecerArquivoCommand : IRequest<long>
    {
        

        public class CreateParecerArquivoCommandHandler : IRequestHandler<CreateParecerArquivoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateParecerArquivoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateParecerArquivoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.ParecerArquivo
                {
                    CodParecer = request.CodParecer,
                    NomeArquivo = request.NomeArquivo,
                    Arquivo = request.Arquivo,
                    Caminho =request.Caminho,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                    
                    
                };

                _context.ParecerArquivo.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodParecerArquivo;
            }
        }
        public int CodParecer { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }
        public string CriadoPor { get; set; }

       
    }
}
