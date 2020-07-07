using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Parecer.Commands.CompleteParecer
{
    public partial class CompleteParecerCommand : IRequest<long>
    {

        public class CompleteParecerCommandHandler : IRequestHandler<CompleteParecerCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CompleteParecerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CompleteParecerCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Parecer.FindAsync(request.CodParecer);

                entity.DscComplemento  = request.DscComplemtoParecer;
                entity.FlgStatusParecer = request.FlgStatusParecer;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);


                foreach (var item in request.ListParecerArquivo)
                {
                    var entityParecerArquivo = new Domain.Entities.ParecerArquivo
                    {
                        CodParecer = entity.CodParecer,
                        Arquivo = item.Arquivo,
                        NomeArquivo = item.NomeArquivo,
                        Caminho = item.Caminho,
                        CriadoPor = request.AlteradoPor,
                        DataCriacao = DateTime.Now,
                        FlagAtivo = true
                    };

                    _context.ParecerArquivo.Add(entityParecerArquivo);

                    await _context.SaveChangesAsync(cancellationToken);
                }

                var entityHistoricoParecer = new Domain.Entities.HistoricoParecer
                {
                    DscParecer = entity.DscParecer,
                    DscComplementoParecer = request.DscComplemtoParecer,
                    DscUltimaOcorrencia = request.DscParecerStatus,
                    CodParecer = entity.CodParecer,
                    DscMotivoDevolucao = entity.DscMotivoDevolucao,
                    CriadoPor = request.AlteradoPor,
                    DataCriacao = DateTime.Now,
                    FlgStatusParecer = request.FlgStatusParecer
                };

                _context.HistoricoParecer.Add(entityHistoricoParecer);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodParecer;
            }
        }
        public int CodParecer { get; set; }
        public int FlgStatusParecer { get; set; }
        public string DscComplemtoParecer { get; set; }
        public string DscParecerStatus { get; set; }
        public string AlteradoPor { get; set; }
        public List<ParecerArquivoDto> ListParecerArquivo { get; set; }
    }
}
