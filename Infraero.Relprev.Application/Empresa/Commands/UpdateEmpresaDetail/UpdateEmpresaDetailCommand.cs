using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using MediatR;

namespace Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresaDetail
{
    public class UpdateEmpresaDetailCommand : IRequest
    {
        public EmpresaDto EmpresaDto { get; set; }

        public class UpdateEmpresaDetailCommandHandler : IRequestHandler<UpdateEmpresaDetailCommand>
        {
            private readonly IApplicationDbContext _context;

            public UpdateEmpresaDetailCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateEmpresaDetailCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Empresas.FindAsync(request.EmpresaDto.CodEmpresa);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Empresa), request.EmpresaDto.CodEmpresa);
                }

                entity.NomRazaoSocial = request.EmpresaDto.NomRazaoSocial;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
