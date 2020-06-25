using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico;

using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AtendimentoTecnicoController : ApiController
    {
        [HttpPost("GetAtendimentoTecnico")]
        [Consumes("application/json")]
        public async Task<List<RelatoDto>> GetAtendimentoTecnico(AtendimentoTecnicoDto.AtendimentoTecnicoRequest obj)
        {
            try
            {
                var result = await Mediator.Send(new GetAtendimentoTecnicoQuery { AtendimentoTecnico = obj });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}