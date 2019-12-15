using System;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocals.Queries.GetSubLocals;

namespace Infraero.Relprev.Application.SubLocals.Commands.UpdateSubLocal
{
    public partial class UpdateSubLocalCommand : IRequest<bool>
    {

        public class UpdateSubLocalCommandHandler : IRequestHandler<UpdateSubLocalCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateSubLocalCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateSubLocalCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.SubLocals.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(SubLocal), request.Id);
                }

                //entity.NomRazaoSocial = request.NomRazaoSocial;
                //entity.NumCnpj = request.NumCnpj;
                //entity.NumTelefone = request.NumTelefone;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string AlteradoPor { get; set; }

        public int Id { get; set; }
    }
}
