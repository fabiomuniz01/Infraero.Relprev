using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.DeleteSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class SubLocalController : ApiController
    {
        [HttpPost("CreateSubLocal")]
        public async Task<ActionResult<long>> CreateSubLocal(CreateSubLocalCommand command)
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

        [HttpGet("GetGridSubLocal")]
        public async Task<GridSubLocal> GetGridSubLocal()
        {
            try
            {
                var result = await Mediator.Send(new GetGridSubLocalsQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetSubLocalById/{id}")]
        public async Task<SubLocalDto> GetSubLocalById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetSubLocalByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPost("UpdateSubLocal")]
        public async Task<ActionResult<bool>> UpdateSubLocal(UpdateSubLocalCommand command)
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
        public async Task<ActionResult<bool>> DeleteSubLocal(int id)
        {
            try
            {
                var result = await Mediator.Send(new DeleteSubLocalCommand { Id = id });
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