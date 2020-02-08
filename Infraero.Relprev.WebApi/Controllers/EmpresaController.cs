using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmpresaController : ApiController
    {
        [HttpPost("CreateEmpresa")]
        public async Task<ActionResult<long>> CreateEmpresa(CreateEmpresaCommand command)
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
        [HttpPost("UpdateEmpresa")]
        public async Task<ActionResult<bool>> UpdateEmpresa(UpdateEmpresaCommand command)
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

        [HttpPost("DeleteEmpresa")]
        public async Task<ActionResult<bool>> DeleteEmpresa(DeleteEmpresaCommand command)
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

        [HttpGet("GetGridEmpresa")]
        public async Task<GridEmpresa> GetGridEmpresa()
        {
            try
            {
                //_logger.LogInformation("API ENTRY: Inside get all empresas API call.");
                var result2 = await Mediator.Send(new GetGridEmpresasQuery());
                return result2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetEmpresaById/{id}")]
        public async Task<EmpresaDto> GetEmpresaById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetEmpresaByIdQuery { Id = id });
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
