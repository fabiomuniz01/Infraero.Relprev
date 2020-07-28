using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Commands.CreateVinculoResponsavelEmpresa;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Commands.DeleteVinculoResponsavelEmpresa;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresas;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class VinculoResponsavelEmpresaController : ApiController
    {
        [HttpPost("CreateVinculoResponsavelEmpresa")]
        public async Task<ActionResult<long>> CreateVinculoResponsavelEmpresa(CreateVinculoResponsavelEmpresaCommand command)
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
        

        [HttpPost("DeleteVinculoResponsavelEmpresa")]
        public async Task<ActionResult<bool>> DeleteVinculoResponsavelEmpresa(DeleteVinculoResponsavelEmpresaCommand command)
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

        [HttpGet("GetGridVinculoResponsavelEmpresa")]
        public async Task<GridVinculoResponsavelEmpresa> GetGridVinculoResponsavelEmpresa()
        {
            try
            {
                //_logger.LogInformation("API ENTRY: Inside get all VinculoResponsavelEmpresas API call.");
                var result2 = await Mediator.Send(new GetGridVinculoResponsavelEmpresasQuery());
                return result2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetVinculoResponsavelEmpresaById/{id}")]
        public async Task<VinculoResponsavelEmpresaDto> GetVinculoResponsavelEmpresaById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetVinculoResponsavelEmpresaByIdQuery { CodVinculoResponsavelEmpresa = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetVinculoResponsavelEmpresaAll")]
        public async Task<List<VinculoResponsavelEmpresaDto>> GetVinculoResponsavelEmpresaAll()
        {
            try
            {
                var result = await Mediator.Send(new GetVinculoResponsavelEmpresaAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpPost("ExistVinculo")]
        public async Task<VinculoResponsavelEmpresaDto> ExistVinculo([FromBody]CreateVinculoResponsavelEmpresaCommand command)
        {
            try
            {
                var result = await Mediator.Send(new ExistVinculoQuery {
                    CodUnidadeInfraestrutura = command.CodUnidadeInfraestrutura,
                    CodEmpresa = command.CodEmpresa
                });
                return await Task.FromResult(result == null ? new VinculoResponsavelEmpresaDto() : new VinculoResponsavelEmpresaDto { CodVinculoResponsavelEmpresa =  result.CodVinculoResponsavelEmpresa });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
