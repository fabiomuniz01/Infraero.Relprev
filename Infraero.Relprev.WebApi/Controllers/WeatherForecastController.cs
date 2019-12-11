using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraero.Relprev.WebApi.Controllers
{
    //[Authorize]
    public class WeatherForecastController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<UsuariosVm>> Get()
        {
            return await Mediator.Send(new GetUsuariosQuery());
        }
    }
}