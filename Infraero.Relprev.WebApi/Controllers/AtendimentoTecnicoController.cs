using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
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
                var result = await Mediator.Send(new GetAtribuicaoRelatoByIdResponsavelQuery()
                {
                    Id = request.CodResponsavelTecnico
                });

                var resultRelato = result.Select(s => s.Relato).ToList();

                if (!request.DtOcorrenciaInicio.IsNullOrEmpty() && !request.DtOcorrenciaFim.IsNullOrEmpty())
                {
                    resultRelato = resultRelato.Where(
                        r => r.DatOcorrencia >= Convert.ToDateTime(request.DtOcorrenciaInicio)
                        && r.DatOcorrencia <= Convert.ToDateTime(request.DtOcorrenciaFim)
                        ).ToList();
                }

                if (!request.NumRelato.IsNullOrEmpty())
                {
                    resultRelato = resultRelato.Where(
                       r => r.NumRelato == request.NumRelato
                       ).ToList();
                }

                if (!request.NumRelato.IsNullOrEmpty())
                {
                    resultRelato = resultRelato.Where(
                       r => r.FlgStatusRelato == Convert.ToInt32(request.FlgStatusRelato)
                       ).ToList();
                }

                return resultRelato;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}