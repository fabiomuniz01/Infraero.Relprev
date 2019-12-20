﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class UnidadeInfraestruturaController : ApiController
    {
        [HttpPost("CreateUnidadeInfraestrutura")]
        public async Task<ActionResult<long>> CreateUnidadeInfraestrutura(CreateUnidadeInfraEstruturaCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetGridUnidadeInfraestrutura")]
        public async Task<GridUnidadeInfraEstrutura> GetGridUnidadeInfraestrutura()
        {
            try
            {
                var result = await Mediator.Send(new GetGridUnidadeInfraestruturaQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetUnidadeInfraestruturaById/{id}")]
        public async Task<UnidadeInfraEstruturaDto> GetUnidadeInfraestruturaById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetUnidadeInfraEstruturaByIdQuery { CodUnidadeInfraestrutura = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetUnidadeInfraestruturaAll")]
        public async Task<List<UnidadeInfraEstruturaDto>> GetUnidadeInfraestruturaAll()
        {
            try
            {
                var result = await Mediator.Send(new GetUnidadeInfraEstruturaAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPost("UpdateUnidadeInfraestrutura")]
        public async Task<ActionResult<bool>> UpdateUnidadeInfraestrutura(UpdateUnidadeInfraEstruturaCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);

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