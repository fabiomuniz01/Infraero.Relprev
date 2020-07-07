using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Infraero.Relprev.Application.Parecer.Commands.AvaluateParecer
{
    public partial class AvaluateParecerCommand : IRequest<long>
    {

        public class AvaluateParecerCommandHandler : IRequestHandler<AvaluateParecerCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public AvaluateParecerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(AvaluateParecerCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Parecer.FindAsync(request.CodParecer);

                
                entity.FlgStatusParecer = request.FlgStatusParecer;
                entity.DscMotivoDevolucao = request.DscMotivoDevolucao;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
               
                await _context.SaveChangesAsync(cancellationToken);

                
                var entityHistoricoParecer = new Domain.Entities.HistoricoParecer
                {
                    DscParecer = entity.DscParecer,
                    DscComplementoParecer = entity.DscComplemento,
                    DscUltimaOcorrencia = request.DscParecerStatus,
                    CodParecer = entity.CodParecer,
                    DscMotivoDevolucao = request.DscMotivoDevolucao,
                    CriadoPor = request.AlteradoPor,
                    DataCriacao = DateTime.Now,
                    FlgStatusParecer = request.FlgStatusParecer
                };

                _context.HistoricoParecer.Add(entityHistoricoParecer);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodParecer;            }
        }

        public string DscMotivoDevolucao { get; set; }
        public string DscParecerStatus { get; set; }
        public string AlteradoPor { get; set; }
        public int CodParecer { get; set; }
        public int FlgStatusParecer { get; set; }
        
    }
}
