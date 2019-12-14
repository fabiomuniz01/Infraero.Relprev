using System;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;

namespace Infraero.Relprev.Application.Empresas.Commands.UpdateEmpresa
{
    public partial class UpdateEmpresaCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string NomRazaoSocial { get; set; }
        public string NumCnpj { get; set; }
        public string NumTelefone { get; set; }
        public string AlteradoPor { get; set; }

        public class UpdateEmpresaCommandHandler : IRequestHandler<UpdateEmpresaCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Empresas.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Empresa), request.Id);
                }

                entity.NomRazaoSocial = request.NomRazaoSocial;
                entity.NumCnpj = request.NumCnpj;
                entity.NumTelefone = request.NumTelefone;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

    }
}
