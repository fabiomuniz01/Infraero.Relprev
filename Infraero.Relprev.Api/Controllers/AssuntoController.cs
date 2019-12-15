using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assuntos.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assuntos.Commands.DeleteAssunto;
using Infraero.Relprev.Application.Assuntos.Commands.UpdateAssunto;
using Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class AssuntoController : ApiController
    {
        [HttpPost("CreateAssunto")]
        public async Task<ActionResult<long>> CreateAssunto(CreateAssuntoCommand command)
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

        [HttpGet("GetGridAssunto")]
        public async Task<GridAssunto> GetGridAssunto()
        {
            try
            {
                var result = await Mediator.Send(new GetGridAssuntosQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpGet("GetAssuntoById/{id}")]
        public async Task<AssuntoDto> GetAssuntoById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetAssuntoByIdQuery {Id = id});
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }


        [HttpPost("UpdateAssunto")]
        public async Task<ActionResult<bool>> UpdateAssunto(UpdateAssuntoCommand command)
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAssunto(int id)
        {
            try
            {
                var result = await Mediator.Send(new DeleteAssuntoCommand { Id = id });
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