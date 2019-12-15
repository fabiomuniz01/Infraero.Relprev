using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnicos.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnicos.Commands.DeleteResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnicos.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnicos.Queries.GetResponsavelTecnicos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class ResponsavelTecnicoController : ApiController
    {
        [HttpPost("CreateResponsavelTecnico")]
        public async Task<ActionResult<long>> CreateResponsavelTecnico(CreateResponsavelTecnicoCommand command)
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

        [HttpGet("GetGridResponsavelTecnico")]
        public async Task<GridResponsavelTecnico> GetGridResponsavelTecnico()
        {
            try
            {
                var result = await Mediator.Send(new GetGridResponsavelTecnicosQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetResponsavelTecnicoById/{id}")]
        public async Task<ResponsavelTecnicoDto> GetResponsavelTecnicoById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetResponsavelTecnicoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPost("UpdateResponsavelTecnico")]
        public async Task<ActionResult<bool>> UpdateResponsavelTecnico(UpdateResponsavelTecnicoCommand command)
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
        public async Task<ActionResult<bool>> DeleteResponsavelTecnico(int id)
        {
            try
            {
                var result = await Mediator.Send(new DeleteResponsavelTecnicoCommand { Id = id });
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