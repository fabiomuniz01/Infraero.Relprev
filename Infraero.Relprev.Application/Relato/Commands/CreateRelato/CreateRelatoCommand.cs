using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Infraero.Relprev.Application.RelatoArquivo.Queries;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

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
                try
                {
                    var entity = new Domain.Entities.Relato
                    {
                        CodUnidadeInfraestrutura = request.CodUnidadeInfraestrutura,
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
                        DataCriacao = DateTime.Now,
                        FlgStatusRelato = request.FlgStatusRelato,
                        NumRelato = ""
                        
                    };

                    _context.Relato.Add(entity);

                    await _context.SaveChangesAsync(cancellationToken);

                    entity.NumRelato = DateTime.Now.Year.ToString() + request.Sigla +
                                       entity.CodRelato.ToString().PadLeft(4, '0').ToString();

                    await _context.SaveChangesAsync(cancellationToken);

                    foreach (var item in request.ListRelatoArquivo)
                    {
                        var entityRelatoArquivo = new Domain.Entities.RelatoArquivo
                        {
                            CodRelato = entity.CodRelato,
                            Arquivo = item.Arquivo,
                            NomeArquivo = item.NomeArquivo,
                            Caminho = item.Caminho,
                            CriadoPor = request.CriadoPor,
                            DataCriacao = DateTime.Now


                        };

                        _context.RelatoArquivo.Add(entityRelatoArquivo);

                        await _context.SaveChangesAsync(cancellationToken);
                    }


                    return entity.CodRelato;
                }
                catch (Exception e)
                {
                    throw e;
                }
                
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
        public string Sigla { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }
        public List<RelatoArquivoDto> ListRelatoArquivo { get; set; }
        public int FlgStatusRelato { get; set; }
    }
}
