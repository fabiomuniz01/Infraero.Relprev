using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
//using Infraero.Relprev.Application.Relato.Commands.FinalizeRelato;
//using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
//using Infraero.Relprev.Application.Relato.Commands.CancelRelato;
//using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class RelatoController : ApiController
    {
        [HttpPost("CreateRelato")]
        public async Task<ActionResult<long>> CreateRelato(CreateRelatoCommand command)
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

        [HttpGet("GetGridRelato")]
        public async Task<GridRelato> GetGridRelato()
        {
            try
            {
                var result = await Mediator.Send(new GetGridRelatosQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        //[HttpGet("GetRelatoById/{id}")]
        //public async Task<RelatoDto> GetRelatoById(int id)
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(new GetRelatoByIdQuery {Id = id});
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
            
        //}


        //[HttpPost("UpdateRelato")]
        //public async Task<ActionResult<bool>> UpdateRelato(UpdateRelatoCommand command)
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(command);

        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }

        //}

        //[HttpPost("DeleteRelato")]
        //public async Task<ActionResult<bool>> DeleteRelato(DeleteRelatoCommand command)
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(command);
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //[HttpGet("GetRelatoAll")]
        //public async Task<List<RelatoDto>> GetRelatoAll()
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(new GetRelatoAllQuery());
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }

        //}
    }
}