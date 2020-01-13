using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Infraero.Relprev.Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class PerfilController : ApiController
    {
        [HttpPost("CreatePerfil")]
        public async Task<ActionResult<long>> CreatePerfil(CreatePerfilCommand command)
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

        [HttpGet("GetGridPerfil")]
        public async Task<GridPerfil> GetGridPerfil()
        {
            try
            {
                var result = await Mediator.Send(new GetGridPerfilsQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetPerfilById/{id}")]
        public async Task<PerfilDto> GetPerfilById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetPerfilByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPost("UpdatePerfil")]
        public async Task<ActionResult<bool>> UpdatePerfil(UpdatePerfilCommand command)
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

        [HttpPost("DeletePerfil")]
        public async Task<ActionResult<bool>> DeletePerfil(DeletePerfilCommand command)
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
