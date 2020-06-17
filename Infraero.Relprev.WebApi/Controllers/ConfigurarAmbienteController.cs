using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ConfigurarAmbiente.Commands.CreateConfigurarAmbiente;
using Infraero.Relprev.Application.ConfigurarAmbiente.Commands.UpdateConfigurarAmbiente;
using Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ConfigurarAmbienteController : ApiController
    {
        [HttpPost("CreateConfigurarAmbiente")]
        public async Task<ActionResult<long>> CreateConfigurarAmbiente(CreateConfigurarAmbienteCommand command)
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
        [HttpPost("UpdateConfigurarAmbiente")]
        public async Task<ActionResult<bool>> UpdateConfigurarAmbiente(UpdateConfigurarAmbienteCommand command)
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

        [HttpGet("GetConfigurarAmbienteById/{id}")]
        public async Task<ConfigurarAmbienteDto> GetConfigurarAmbienteById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetConfigurarAmbienteByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetConfigurarAmbienteAll")]
        public async Task<List<ConfigurarAmbienteDto>> GetConfigurarAmbienteAll()
        {
            try
            {
                var result = await Mediator.Send(new GetConfigurarAmbienteAllQuery());
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