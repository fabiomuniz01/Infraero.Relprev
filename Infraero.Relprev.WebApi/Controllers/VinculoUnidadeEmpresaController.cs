using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.CreateVinculoUnidadeEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.DeleteVinculoUnidadeEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresas;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class VinculoUnidadeEmpresaController : ApiController
    {
        [HttpPost("CreateVinculoUnidadeEmpresa")]
        public async Task<ActionResult<long>> CreateVinculoUnidadeEmpresa(CreateVinculoUnidadeEmpresaCommand command)
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
        

        [HttpPost("DeleteVinculoUnidadeEmpresa")]
        public async Task<ActionResult<bool>> DeleteVinculoUnidadeEmpresa(DeleteVinculoUnidadeEmpresaCommand command)
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

        [HttpGet("GetGridVinculoUnidadeEmpresa")]
        public async Task<GridVinculoUnidadeEmpresa> GetGridVinculoUnidadeEmpresa()
        {
            try
            {
                //_logger.LogInformation("API ENTRY: Inside get all VinculoUnidadeEmpresas API call.");
                var result2 = await Mediator.Send(new GetGridVinculoUnidadeEmpresasQuery());
                return result2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetVinculoUnidadeEmpresaById/{id}")]
        public async Task<VinculoUnidadeEmpresaDto> GetVinculoUnidadeEmpresaById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetVinculoUnidadeEmpresaByIdQuery { CodVinculoUnidadeEmpresa = id });
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
