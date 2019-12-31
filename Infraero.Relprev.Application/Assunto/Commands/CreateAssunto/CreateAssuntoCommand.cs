using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Assunto.Commands.CreateAssunto
{
    public class CreateAssuntoCommand : IRequest<long>
    {
        

        public class CreateAssuntoCommandHandler : IRequestHandler<CreateAssuntoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateAssuntoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateAssuntoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Assunto
                {
                    DscAssunto = request.DscAssunto,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.Assunto.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodAssunto;
            }
        }

        public string CriadoPor { get; set; }
        public string DscAssunto { get; set; }
    }
}
