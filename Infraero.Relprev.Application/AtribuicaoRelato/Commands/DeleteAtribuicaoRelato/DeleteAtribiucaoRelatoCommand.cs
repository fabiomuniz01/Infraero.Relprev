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

namespace Infraero.Relprev.Application.AtribuicaoRelato.Commands.DeleteAtribiucaoRelato
{
    public partial class DeleteAtribiucaoRelatoCommand : IRequest<long>
    {

        public class DeleteAtribiucaoRelatoCommandHandler : IRequestHandler<DeleteAtribiucaoRelatoCommand, long>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public DeleteAtribiucaoRelatoCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<long> Handle(DeleteAtribiucaoRelatoCommand request, CancellationToken cancellationToken)
            {
                try
                {

                    var entityAtribuicaoRelato = new Domain.Entities.AtribuicaoRelato
                    {
                        CodAtribuicaoRelato = request.CodAtribuicao
                       
                    };

                    _context.AtribuicaoRelato.Remove(entityAtribuicaoRelato);

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
       
       
    }
}
