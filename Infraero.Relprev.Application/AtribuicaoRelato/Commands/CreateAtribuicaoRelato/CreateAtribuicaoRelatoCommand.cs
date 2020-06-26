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
                        CodUsuarioAtribuidor = request.CodUsuarioAtribuidor,
                        DthAtribuicao = DateTime.Now,
                        CriadoPor = request.CriadoPor,
                        DataCriacao = DateTime.Now,
                        FlagAtivo = request.FlagAtivo
                    };

                    _context.AtribuicaoRelato.Add(entity);

                    await _context.SaveChangesAsync(cancellationToken);

                  
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public string CodUsuarioAtribuidor { get; set; }

        public int CodRelato { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
        public int CodResponsavelTecnico { get; set; }
        public string CriadoPor { get; set; }
        public bool FlagAtivo { get; set; }
        public int FlgStatusRelato { get; set; }
        public string DscAtribuicao { get; set; }
    }
}
