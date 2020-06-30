using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AtendimentoTecnicoController : ApiController
    {
        [HttpPost]
        [Route("GetAtendimentoTecnico")]
        public async Task<List<RelatoDto>> GetAtendimentoTecnico([FromBody] AtendimentoRequest request)
        {
            try
            {
                var result = await Mediator.Send(new GetAtribuicaoRelatoByIdResponsavelQuery() { Id = request.CodResponsavelTecnico });
                return result.Select(s=>s.Relato).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}