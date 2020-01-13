﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;

namespace Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico
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
                var entity = await _context.ResponsavelTecnico.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(ResponsavelTecnico), request.Id);
                }

                entity.NumDocumento = request.NumDocumento;
                entity.EndEmail = request.EndEmail;
                entity.NumTelefone = request.NumTelefone;
                entity.CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura;

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
        public string NumDocumento { get; set; }
        public int CodEmpresaResponsavelTecnico { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
    }
}
