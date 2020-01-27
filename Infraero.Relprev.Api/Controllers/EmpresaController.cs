using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;

namespace Infraero.Relprev.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    public class EmpresaController : ApiController
    {
        
        private readonly ILogger<EmpresaController> _logger;
        public EmpresaController(ILogger<EmpresaController> logger)
        {
            _logger = logger;
        }

        //[ClaimsAuthorize("Empresa", "Create")]
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
        //[ClaimsAuthorize("Empresa", "Search")]
        [HttpGet("GetGridEmpresa")]
        public async Task<GridEmpresa> GetGridEmpresa()
        {
            try
            {
                _logger.LogInformation("API ENTRY: Inside get all empresas API call.");
                var result2 = await Mediator.Send(new GetGridEmpresasQuery());
                return result2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        //[ClaimsAuthorize("Empresa", "Search")]
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
        //[ClaimsAuthorize("Empresa", "Search")]
        [HttpGet("GetEmpresaAll")]
        public async Task<List<EmpresaDto>> GetEmpresaAll()
        {
            try
            {
                var result = await Mediator.Send(new GetEmpresaAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        //[ClaimsAuthorize("Empresa", "Update")]
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
        //[ClaimsAuthorize("Empresa", "Delete")]
        [HttpPost("DeleteEmpresa")]
        public async Task<ActionResult<bool>> DeleteEmpresa(DeleteEmpresaCommand command)
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