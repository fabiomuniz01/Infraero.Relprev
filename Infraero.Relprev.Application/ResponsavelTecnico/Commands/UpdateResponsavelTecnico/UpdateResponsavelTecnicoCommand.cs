using System;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnicos.Queries.GetResponsavelTecnicos;

namespace Infraero.Relprev.Application.ResponsavelTecnicos.Commands.UpdateResponsavelTecnico
{
    public partial class UpdateResponsavelTecnicoCommand : IRequest<bool>
    {
        

        public class UpdateResponsavelTecnicoCommandHandler : IRequestHandler<UpdateResponsavelTecnicoCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateResponsavelTecnicoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateResponsavelTecnicoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.ResponsavelTecnicos.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(ResponsavelTecnico), request.Id);
                }

                entity.NomResponsavelTecnico = request.NomResponsavelTecnico;
                entity.NumCpf = request.NumCpf;
                entity.NumTelefone = request.NumTelefone;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public int Id { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string DscLogin { get; set; }
        public string DscSenha { get; set; }
        public DateTime DthRegistro { get; set; }
        public string EndEmail { get; set; }
        public int QtdTentativasIncorretas { get; set; }
        public string FlgPrimeiroAcesso { get; set; }
        public string FlgResponsavelTecnicoBloqueado { get; set; }
        public string AlteradoPor { get; set; }
    }
}
