using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Infraero.Relprev.Application.RelatoArquivo.Queries;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Infraero.Relprev.Application.Relato.Commands.CreateRelato
{
    public class CreateRelatoCommand : IRequest<long>
    {
        public class CreateRelatoCommandHandler : IRequestHandler<CreateRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public CreateRelatoCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
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
                        NomRelator = request.NomRelator,
                        EmailRelator = request.EmailRelator,
                        NumTelefoneRelator = request.NumTelefoneRelator,
                        NomEmpresaRelator = request.NomEmpresaRelator,
                        CriadoPor = request.CriadoPor,
                        DataCriacao = DateTime.Now,
                        //Rn0033 - Nao Iniciado
                        FlgStatusRelato = request.FlgStatusRelato,
                        FlagAtivo = true,
                        NumRelato = string.Empty
                    };

                    _context.Relato.Add(entity);

                    await _context.SaveChangesAsync(cancellationToken);

                    //Rn0033 - Ocorrencia Não Iniciada
                    var entityHistoricoRelato = new Domain.Entities.HistoricoRelato
                    {
                        CodRelato = entity.CodRelato,
                        DscNaoIniciado = request.DscOcorrenciaStatus,
                        CriadoPor = request.CriadoPor,
                        DataCriacao = DateTime.Now
                    };

                    _context.HistoricoRelato.Add(entityHistoricoRelato);

                    await _context.SaveChangesAsync(cancellationToken);

                    //Rn0086
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
                            DataCriacao = DateTime.Now,
                            FlagAtivo = true
                        };

                        _context.RelatoArquivo.Add(entityRelatoArquivo);

                        await _context.SaveChangesAsync(cancellationToken);
                    }
                    //Rn0032
                    var listUsuario = await _context.ResponsavelTecnico.Where(x =>
                            x.CodUnidadeInfraestrutura == request.CodUnidadeInfraestrutura
                            && x.FlagGestorSgso == true)
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .ToListAsync(cancellationToken);


                    foreach (var usu in listUsuario)
                    {
                        var entityAtribuicaoRelato = new Domain.Entities.AtribuicaoRelato
                        {
                            CodRelato = entity.CodRelato,
                            CodResponsavelTecnico = usu.CodResponsavelTecnico,
                            CodSituacaoAtribuicao = request.CodSituacaoAtribuicao,
                            DthAtribuicao = DateTime.Now,
                            CriadoPor = request.CriadoPor,
                            DataCriacao = DateTime.Now,
                            FlagAtivo = true
                        };

                        _context.AtribuicaoRelato.Add(entityAtribuicaoRelato);

                        await _context.SaveChangesAsync(cancellationToken);
                    }


                    //Rn0039 - Ocorrência Atribuída
                    entityHistoricoRelato.DscAtribuicao = "Ocorrência Atribuída, " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm");
                    entityHistoricoRelato.AlteradoPor = request.CriadoPor;
                    entityHistoricoRelato.DataAlteracao = DateTime.Now;

                    await _context.SaveChangesAsync(cancellationToken);

                    return entity.CodRelato;
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
        }

        public string DscOcorrenciaStatus { get; set; }

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
        public string CodPerfilSgso { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
    }
}
