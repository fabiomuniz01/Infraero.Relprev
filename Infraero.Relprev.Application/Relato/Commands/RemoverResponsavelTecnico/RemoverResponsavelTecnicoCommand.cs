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

namespace Infraero.Relprev.Application.Relato.Commands.RemoverResponsavelTecnico
{
    public partial class RemoverResponsavelTecnicoCommand : IRequest<long>
    {

        public class RemoverResponsavelTecnicoCommandHandler : IRequestHandler<RemoverResponsavelTecnicoCommand, long>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public RemoverResponsavelTecnicoCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<long> Handle(RemoverResponsavelTecnicoCommand request, CancellationToken cancellationToken)
            {
                try
                {

                    var entityAtribuicaoRelato = new Domain.Entities.AtribuicaoRelato
                    {
                        CodAtribuicaoRelato = request.CodAtribuicao,
                        CodSituacaoAtribuicao = request.CodSituacaoAtribuicao,
                        DthAtribuicao = DateTime.Now,
                        CriadoPor = request.AlteradoPor,
                        DataCriacao = DateTime.Now,
                        FlagAtivo = false
                    };

                    _context.AtribuicaoRelato.Add(entityAtribuicaoRelato);

                    await _context.SaveChangesAsync(cancellationToken);
                    
                    return request.CodAtribuicao;
                }
                catch
                {
                    return 0;
                }
            }
        }
        public int CodAtribuicao { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public string AlteradoPor { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
       
    }
}
