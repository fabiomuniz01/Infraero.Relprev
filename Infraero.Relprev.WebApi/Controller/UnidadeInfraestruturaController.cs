using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Microsoft.AspNetCore.Authorization;

namespace Infraero.Relprev.WebApi.Controller
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/UnidadeInfraestrutura")]
    [ApiVersion("1.0")]
    [ApiController]
    public class UnidadeInfraestruturaController : ApiController
    {
        [HttpPost("CreateUnidadeInfraestrutura")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<ActionResult<long>> CreateUnidadeInfraestrutura(CreateUnidadeInfraEstruturaCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await Mediator.Send(command);

            return Created($"{result}", result);
        }

        [HttpGet("GetGridUnidadeInfraestrutura")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GridUnidadeInfraEstrutura), Description = "Returns finded cars array")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Missing or invalid pageNumber or pageSize")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetGridUnidadeInfraestrutura()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await Mediator.Send(new GetGridUnidadeInfraestruturaQuery());
            return Ok(result);
        }
    }
}
