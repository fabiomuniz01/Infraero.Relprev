using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ParecerArquivo.Commands.CreateParecerArquivo;
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ParecerArquivoController : ApiController
    {
        [HttpPost("CreateParecerArquivo")]
        public async Task<ActionResult<long>> CreateParecerArquivo(CreateParecerArquivoCommand command)
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

        [HttpGet("GetGridParecerArquivo")]
        public async Task<List<ParecerArquivoDto>> GetGridParecerArquivo()
        {
            try
            {
                var result = await Mediator.Send(new GetParecerArquivoAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpGet("GetParecerArquivoById/{id}")]
        public async Task<ParecerArquivoDto> GetParecerArquivoById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerArquivoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetParecerArquivoByIdParecer/{id}")]
        public async Task<List<ParecerArquivoDto>> GetParecerArquivoByIdParecer(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerArquivoByIdParecerQuery { Id = id });
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