using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.AtribuirResponsavelRelato)]
    public class AtribuirRespRelatoController : Controller
    {
        // GET: AtribuirRespRelato
        public ActionResult Index()
        {
            return View();
        }
    }
}