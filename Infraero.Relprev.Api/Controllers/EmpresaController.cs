using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresas.Commands.CreateEmpresa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmpresaController : ApiController
    {
        [HttpPost("create")]
        public async Task<ActionResult<long>> Create(CreateEmpresaCommand command)
        {
            var result = await Mediator.Send(command);

            return result;
        }
    }
}