using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;

namespace Infraero.Relprev.Application.Empresas.Commands.CreateEmpresa
{
    public class CreateEmpresaCommand : IRequest<long>
    {
        public EmpresaDto EmpresaDto { get; set; }

        public class CreateEmpresaCommandHandler : IRequestHandler<CreateEmpresaCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = new Empresa
                {
                    NomRazaoSocial = request.EmpresaDto.NomRazaoSocial,
                };

                _context.Empresas.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodEmpresa;
            }
        }
    }
}
