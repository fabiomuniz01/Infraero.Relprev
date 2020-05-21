using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Entities;
using MediatR;

namespace Infraero.Relprev.Application.Relato.Commands.CreateRelato
{
    public class CreateRelatoCommand : IRequest<long>
    {
        public class CreateRelatoCommandHandler : IRequestHandler<CreateRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateRelatoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateRelatoCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Relato
                {

                    DatOcorrencia = Convert.ToDateTime(request.DatOcorrencia),
                    HorOcorrencia = request.HorOcorrencia,
                    DscEnvolvidosOcorrencia = request.DscEnvolvidosOcorrencia,
                    DscLocalOcorrenciaRelator = request.DscLocalOcorrenciaRelator,
                    DscOcorrenciaRelator = request.DscLocalOcorrenciaRelator,
                    DscRelato = request.DscRelato,
                    NomRelator = request.NomRelator,
                    EmailRelator = request.EmailRelator,
                    NumTelefoneRelator = request.NumTelefoneRelator,
                    NomEmpresaRelator = request.NomEmpresaRelator,
                    CriadoPor = request.CriadoPor,
                    ListArquivo = request.ListArquivo,
                    DataCriacao = DateTime.Now
                };

                _context.Relato.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodRelato;
            }
        }

        public string CriadoPor { get; set; }

        public int CodRelato { get; set; }
        public string DscRelato { get; set; }
        public string DatOcorrencia { get; set; }
        public string HorOcorrencia { get; set; }

        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }
        public ICollection<RelatoArquivo> ListArquivo { get; private set; }
    }
}
