using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Parecer.Commands.UpdateParecer
{
    public partial class UpdateParecerCommand : IRequest<bool>
    {

        public class UpdateParecerCommandHandler : IRequestHandler<UpdateParecerCommand, bool>
        {
            private readonly IApplicationDbContext _context;

            public UpdateParecerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(UpdateParecerCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Parecer.FindAsync(request.CodParecer);

                
                entity.FlgStatusParecer = request.FlgStatusParecer;
                entity.AlteradoPor = request.AlteradoPor;
                entity.DataAlteracao = DateTime.Now;
                await _context.SaveChangesAsync(cancellationToken);

                var entityHistorico = await _context.HistoricoParecer
                    .Where(x => x.CodParecer == entity.CodParecer)
                    .FirstOrDefaultAsync(cancellationToken);

                
                entityHistorico.DscParecer = request.DscParecer;
                entityHistorico.AlteradoPor = request.AlteradoPor;
                entityHistorico.DataAlteracao = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }

        public string DscParecer { get; set; }
        public string AlteradoPor { get; set; }
        public int CodParecer { get; set; }
        public int FlgStatusParecer { get; set; }
        
    }
}
