using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresas.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresas.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
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

        [HttpGet("GetGridEmpresa")]
        public async Task<GridEmpresa> GetGridEmpresa()
        {
            try
            {
                var result = await Mediator.Send(new GetGridEmpresasQuery());
                return result;
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
                var result = await Mediator.Send(new GetEmpresaByIdQuery {Id = id});
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
    }
}