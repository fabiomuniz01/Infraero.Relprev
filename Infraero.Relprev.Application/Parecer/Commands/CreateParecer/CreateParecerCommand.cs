using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;
using Infraero.Relprev.Application.ParecerArquivo.Queries;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Infraero.Relprev.Application.Parecer.Commands.CreateParecer
{
    public class CreateParecerCommand : IRequest<long>
    {
        public class CreateParecerCommandHandler : IRequestHandler<CreateParecerCommand, long>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public CreateParecerCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<long> Handle(CreateParecerCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    var entity = new Domain.Entities.Parecer
                    {
                        DscParecer = request.DscParecer,
                        CodRelato = request.CodRelato,
                        CriadoPor = request.CriadoPor,
                        DataCriacao = DateTime.Now,
                        FlgStatusParecer = request.FlgStatusParecer,
                        FlagAtivo = true
                    };

                    _context.Parecer.Add(entity);

                    await _context.SaveChangesAsync(cancellationToken);

                    //[RN0045]
                    var entityHistoricoParecer = new Domain.Entities.HistoricoParecer
                    {
                        DscUltimaOcorrencia = request.DscParecerStatus,

                        CodParecer = entity.CodParecer,
                        DscParecer = request.DscParecer,
                        CriadoPor = request.CriadoPor,
                        DataCriacao = DateTime.Now
                    };

                    _context.HistoricoParecer.Add(entityHistoricoParecer);

                    await _context.SaveChangesAsync(cancellationToken);


                    foreach (var item in request.ListParecerArquivo)
                    {
                        var entityParecerArquivo = new Domain.Entities.ParecerArquivo
                        {
                            CodParecer = entity.CodParecer,
                            Arquivo = item.Arquivo,
                            NomeArquivo = item.NomeArquivo,
                            Caminho = item.Caminho,
                            CriadoPor = request.CriadoPor,
                            DataCriacao = DateTime.Now,
                            FlagAtivo = true
                        };

                        _context.ParecerArquivo.Add(entityParecerArquivo);

                        await _context.SaveChangesAsync(cancellationToken);
                    }

                    var entityRelato = await _context.Relato.FindAsync(request.CodRelato);

                    entityRelato.FlgStatusRelato = request.FlgStatusRelato;
                    entityRelato.AlteradoPor = request.CriadoPor;
                    entityRelato.DataAlteracao = DateTime.Now;

                    await _context.SaveChangesAsync(cancellationToken);

                    var entityHistorico = await _context.HistoricoRelato
                        .Where(x => x.CodRelato == entity.CodRelato)
                        .FirstOrDefaultAsync(cancellationToken);

                    //Rn0045 - Ocorrência atendida, DD/MM/AAAA, HH:MM 
                    entityHistorico.DscParecer = request.DscParecerStatus;
                    entityHistorico.AlteradoPor = request.CriadoPor;
                    entityHistorico.DataAlteracao = DateTime.Now;

                    await _context.SaveChangesAsync(cancellationToken);

                    return entity.CodParecer;
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
        }
        public int CodRelato { get; set; }
        public string DscParecer { get; set; }
        public string DscParecerStatus { get; set; }
        public string CriadoPor { get; set; }
        public List<ParecerArquivoDto> ListParecerArquivo { get; set; }
        public int FlgStatusParecer { get; set; }
        public int FlgStatusRelato { get; set; }

    }
}
