//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Infraero.Relprev.Application.Empresa.Queries.GetEmpresa;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Infraero.Relprev.Api.Controllers
//{
    
//    public class EmpresaController : ApiController
//    {
//        public async Task<ActionResult<EmpresaListVm>> GetAll()
//        {
//            return await Mediator.Send(new GetEmpresaListQuery());
//        }

//        public async Task<ActionResult<EmpresaVm>> Get(long id)
//        {
//            return await Mediator.Send(new GetEmpresaQuery {Id = id});
//        }
//    }
//}