using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;

using Microsoft.AspNetCore.Mvc;


namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RelatoArquivoController : ApiController
    {
        [HttpPost("CreateRelatoArquivo")]
        public async Task<ActionResult<long>> CreateRelatoArquivo(CreateRelatoArquivoCommand command)
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

        //[HttpGet("GetGridRelatoArquivo")]
        //public async Task<GridRelatoArquivo> GetGridRelatoArquivo()
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(new GetGridRelatoArquivoQuery());
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
            
        //}

        [HttpGet("GetRelatoArquivoById/{id}")]
        public async Task<RelatoArquivoDto> GetRelatoArquivoById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoArquivoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetRelatoArquivosById/{id}")]
        public async Task<RelatoArquivoDto> GetRelatoArquivosById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoArquivoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        [HttpGet("GetRelatoArquivoByIdRelato/{id}")]
        public async Task<List<RelatoArquivoDto>> GetRelatoArquivoByIdRelato(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoArquivoByIdRelatoQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        //[HttpPost("DeleteRelatoArquivo")]
        //public async Task<ActionResult<bool>> DeleteRelatoArquivo(DeleteRelatoArquivoCommand command)
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