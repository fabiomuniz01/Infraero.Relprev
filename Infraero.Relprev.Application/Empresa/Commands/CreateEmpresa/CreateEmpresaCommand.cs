using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa
{
    public class CreateEmpresaCommand : IRequest<long>
    {
        public string Nome { get; set; }
        public string CriadoPor { get; set; }

        public string Telefone { get; set; }

        public string Cnpj { get; set; }

        public class CreateEmpresaCommandHandler : IRequestHandler<CreateEmpresaCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateEmpresaCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateEmpresaCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Empresa
                {
                    NomRazaoSocial = request.Nome,
                    NumCnpj = request.Cnpj,
                    DthRegistro = DateTime.Now,
                    NumTelefone = request.Telefone,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.Empresa.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodEmpresa;
            }
        }

        
    }
}
