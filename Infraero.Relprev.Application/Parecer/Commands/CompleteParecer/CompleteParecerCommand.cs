using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Relato.Commands.CompleteParecer
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

                var entityHistorico = await _context.HistoricoParecer
                    .Where(x => x.CodParecer == entity.CodParecer)
                    .FirstOrDefaultAsync(cancellationToken);

                entityHistorico.DscComplementoParecer = request.DscComplemtoParecer;
                entityHistorico.AlteradoPor = request.AlteradoPor;
                entityHistorico.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return entity.CodParecer;
            }
        }
        public int CodParecer { get; set; }
        public int FlgStatusParecer { get; set; }
        public string DscComplemtoParecer { get; set; }
        public string AlteradoPor { get; set; }
    }
}
