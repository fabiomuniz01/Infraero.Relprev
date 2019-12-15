using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.DeleteUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ApiController
    {
        [HttpPost("CreateUsuario")]
        public async Task<ActionResult<long>> CreateUsuario(CreateUsuarioCommand command)
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

        [HttpGet("GetGridUsuario")]
        public async Task<GridUsuario> GetGridUsuario()
        {
            try
            {
                var result = await Mediator.Send(new GetGridUsuariosQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetUsuarioById/{id}")]
        public async Task<UsuarioDto> GetUsuarioById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetUsuarioByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPost("UpdateUsuario")]
        public async Task<ActionResult<bool>> UpdateUsuario(UpdateUsuarioCommand command)
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
        public async Task<ActionResult<bool>> DeleteUsuario(int id)
        {
            try
            {
                var result = await Mediator.Send(new DeleteUsuarioCommand { Id = id });
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