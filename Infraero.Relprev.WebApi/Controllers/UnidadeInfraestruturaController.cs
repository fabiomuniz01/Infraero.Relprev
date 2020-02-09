using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.DeleteUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UnidadeInfraEstruturaController : ApiController
    {
        [HttpPost("CreateUnidadeInfraEstrutura")]
        public async Task<ActionResult<long>> CreateUnidadeInfraEstrutura(CreateUnidadeInfraEstruturaCommand command)
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
        [HttpPost("UpdateUnidadeInfraEstrutura")]
        public async Task<ActionResult<bool>> UpdateUnidadeInfraEstrutura(UpdateUnidadeInfraEstruturaCommand command)
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

        [HttpPost("DeleteUnidadeInfraEstrutura")]
        public async Task<ActionResult<bool>> DeleteUnidadeInfraEstrutura(DeleteUnidadeInfraEstruturaCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetUnidadeInfraEstruturaAll")]
        public async Task<List<UnidadeInfraEstruturaDto>> GetUnidadeInfraEstruturaAll()
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

        [HttpGet("GetGridUnidadeInfraEstrutura")]
        public async Task<GridUnidadeInfraEstrutura> GetGridUnidadeInfraEstrutura()
        {
            try
            {
                //_logger.LogInformation("API ENTRY: Inside get all UnidadeInfraEstruturas API call.");
                var result2 = await Mediator.Send(new GetGridUnidadeInfraestruturaQuery());
                return result2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetUnidadeInfraEstruturaById/{id}")]
        public async Task<UnidadeInfraEstruturaDto> GetUnidadeInfraEstruturaById(int id)
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

        [HttpGet("GetDependenciaAll")]
        public async Task<List<UnidadeInfraEstruturaDto.Dependencia>> GetDependenciaAll()
        {
            try
            {
                var result = await Mediator.Send(new GetDependenciaAllQuery());
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
