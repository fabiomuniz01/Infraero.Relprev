using Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.DeleteUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuarioDetail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Authorize]
    public class UsuariosController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<long>> Create(CreateUsuarioCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(long id, UpdateUsuarioCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult> UpdateItemDetails(long id, UpdateUsuarioDetailCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            await Mediator.Send(new DeleteUsuarioCommand { Id = id });

            return NoContent();
        }
    }
}
