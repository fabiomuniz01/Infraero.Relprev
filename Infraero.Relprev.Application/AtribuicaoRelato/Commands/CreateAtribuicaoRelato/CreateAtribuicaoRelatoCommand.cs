using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato
{
    public class CreateAtribuicaoRelatoCommand : IRequest<bool>
    {
        public class CreateAtribuicaoRelatoCommandHandler : IRequestHandler<CreateAtribuicaoRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public CreateAtribuicaoRelatoCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }



            public async Task<bool> Handle(CreateAtribuicaoRelatoCommand request, CancellationToken cancellationToken)
            {
                try
                {

                    var entity = new Domain.Entities.AtribuicaoRelato
                    {
                        CodRelato = request.CodRelato,
                        CodResponsavelTecnico = request.CodResponsavelTecnico,
                        CodSituacaoAtribuicao = request.CodSituacaoAtribuicao,
                        DthAtribuicao = DateTime.Now,
                        CriadoPor = request.AlteradoPor,
                        DataCriacao = DateTime.Now,
                        FlagAtivo = true
                    };

                    _context.AtribuicaoRelato.Add(entity);

                    await _context.SaveChangesAsync(cancellationToken);

                    var entityRelato = await _context.Relato.FindAsync(request.CodRelato);

                    if (entity == null)
                    {
                        throw new NotFoundException(nameof(Domain.Entities.Relato), request.CodRelato);
                    }

                    entityRelato.AlteradoPor = request.CriadoPor;
                    entityRelato.DataAlteracao = DateTime.Now;


                    var entityHistorico = await _context.HistoricoRelato
                      .Where(x => x.CodRelato == request.CodRelato)
                      .FirstOrDefaultAsync(cancellationToken);

                    entityHistorico.DscUltimaOcorrencia = entityRelato.DscOcorrenciaRelator;
                    //Rn0039 - Ocorrência atribuída 
                    entityHistorico.DscAtribuicao = request.DscAtribuicao;
                    entityHistorico.AlteradoPor = request.AlteradoPor;
                    entityHistorico.DataAlteracao = DateTime.Now;

                    await _context.SaveChangesAsync(cancellationToken);
                    //Rn0033 - Ocorrência atribuida 
                    entityRelato.FlgStatusRelato = request.FlgStatusRelato;

                    await _context.SaveChangesAsync(cancellationToken);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public string DscAtribuicao { get; set; }

        public string AlteradoPor { get; set; }
        public int CodRelato { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
        public int CodResponsavelTecnico { get; set; }
        public string CriadoPor { get; set; }
        public int FlgStatusRelato { get; set; }
    }
}
