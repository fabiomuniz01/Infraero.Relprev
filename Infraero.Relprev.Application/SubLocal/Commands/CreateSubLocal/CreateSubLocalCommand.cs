using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal
{
    public class CreateSubLocalCommand : IRequest<long>
    {
        public class CreateSubLocalCommandHandler : IRequestHandler<CreateSubLocalCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateSubLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateSubLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.SubLocal
                {
                    //NomRazaoSocial = request.Nome,
                    //NumCnpj = request.Cnpj,
                    //DthRegistro = DateTime.Now,
                    //NumTelefone = request.Telefone,
                    CriadoPor = request.CriadoPor,
                    DataCriacao = DateTime.Now
                };

                _context.SubLocals.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodSubLocal;
            }
        }

        public string CriadoPor { get; set; }

        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }


    }
}
