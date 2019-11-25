using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario
{
    public class CreateUsuarioCommand : IRequest<long>
    {
        public int ListId { get; set; }

        public string Title { get; set; }

        public class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateUsuarioCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
            {
                var entity = new Usuario
                {
                    ListId = request.ListId,
                    Title = request.Title,
                    Done = false
                };

                _context.Usuarios.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
