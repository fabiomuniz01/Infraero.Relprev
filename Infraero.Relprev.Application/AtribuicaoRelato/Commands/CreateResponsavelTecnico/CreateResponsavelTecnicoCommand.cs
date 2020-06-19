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
using Infraero.Relprev.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateResponsavelTecnico
{
    public partial class CreateResponsavelTecnicoCommand : IRequest<long>
    {

        public class CreateResponsavelTecnicoCommandHandler : IRequestHandler<CreateResponsavelTecnicoCommand, long>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public CreateResponsavelTecnicoCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<long> Handle(CreateResponsavelTecnicoCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    var entity = await _context.Relato.FindAsync(request.CodRelato);
                    entity.AlteradoPor = request.AlteradoPor;
                    entity.DataAlteracao = DateTime.Now;
                    entity.FlgStatusRelato = request.FlgStatusRelato;

                    await _context.SaveChangesAsync(cancellationToken);

                    var entityAtribuicaoRelato = new Domain.Entities.AtribuicaoRelato
                    {
                        CodRelato = entity.CodRelato,
                        CodResponsavelTecnico = request.CodResponsavelTecnico,
                        CodSituacaoAtribuicao = request.CodSituacaoAtribuicao,
                        DthAtribuicao = DateTime.Now,
                        CriadoPor = request.AlteradoPor,
                        DataCriacao = DateTime.Now,
                        FlagAtivo = true
                    };

                    _context.AtribuicaoRelato.Add(entityAtribuicaoRelato);

                    await _context.SaveChangesAsync(cancellationToken);
                  
                    return request.CodResponsavelTecnico;
                }
                catch
                {
                    return 0;
                }
            }
        }
        public int CodRelato { get; set; }

        public string DscRelato { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }

        public string AlteradoPor { get; set; }
        public int FlgStatusRelato { get; set; }
        public string CodPerfilSgso { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
        public int CodResponsavelTecnico { get; set; }

        //public List<UsuarioDto> ListUsuario { get; set; }

    }
}
