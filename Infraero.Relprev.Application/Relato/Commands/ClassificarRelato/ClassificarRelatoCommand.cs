using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infraero.Relprev.Application.Common.Exceptions;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Infraero.Relprev.Application.Relato.Commands.ClassificarRelato
{
    public partial class ClassificarRelatoCommand : IRequest<bool>
    {

        public class ClassificarRelatoCommandHandler : IRequestHandler<ClassificarRelatoCommand, bool>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public ClassificarRelatoCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<bool> Handle(ClassificarRelatoCommand request, CancellationToken cancellationToken)
            {
                try
                {


                    var entity = await _context.Relato.FindAsync(request.CodRelato);

                    if (entity == null)
                    {
                        throw new NotFoundException(nameof(Domain.Entities.Relato), request.CodUnidadeInfraestrutura);
                    }

                    entity.AlteradoPor = request.AlteradoPor;
                    entity.DataAlteracao = DateTime.Now;
                    entity.FlgStatusRelato = request.FlgStatusRelato;
                    entity.CodLocal = request.CodLocal;
                    entity.CodSubLocal = request.CodSubLocal;
                    entity.CodAssunto = request.CodAssunto;
                    entity.CodSubAssunto = request.CodSubAssunto;

                    await _context.SaveChangesAsync(cancellationToken);

                    //Atendendo a RN0089

                    var listUsuario = await _context.Usuario.Where(x =>
                                x.CodPerfil == request.CodPerfilSgso &&
                                x.CodUnidadeInfraestrutura == request.CodUnidadeInfraestrutura)
                            .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                            .ToListAsync(cancellationToken);

                    foreach (var usu in listUsuario)
                    {
                        var objResposavelTecnico = await _context.ResponsavelTecnico
                        .Where(x => x.NumCpf == usu.NumCpf)
                        .ProjectTo<ResponsavelTecnicoDto>(_mapper.ConfigurationProvider)
                        .OrderBy(t => t.CodResponsavelTecnico)
                        .FirstOrDefaultAsync(cancellationToken);

                        if (objResposavelTecnico != null)
                        {
                            var entityAtribuicaoRelato = new Domain.Entities.AtribuicaoRelato
                            {
                                CodRelato = entity.CodRelato,
                                CodResponsavelTecnicoSgso = objResposavelTecnico.CodResponsavelTecnico,
                                CodSituacaoAtribuicao = request.CodSituacaoAtribuicao,
                                DthAtribuicao = DateTime.Now,
                                CriadoPor = request.AlteradoPor,
                                DataCriacao = DateTime.Now,
                                FlagAtivo = true
                            };

                            _context.AtribuicaoRelato.Add(entityAtribuicaoRelato);

                            await _context.SaveChangesAsync(cancellationToken);
                        }
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public int CodRelato { get; set; }

        public string DscRelato { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int CodLocal { get; set; }
        public int CodSubLocal { get; set; }
        public int CodAssunto { get; set; }
        public int CodSubAssunto { get; set; }
        public int FlgStatusRelato { get; set; }
        public string CodPerfilSgso { get; set; }
        public int CodSituacaoAtribuicao { get; set; }

    }
}
