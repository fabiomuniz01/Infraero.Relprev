using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class AtribuirRespRelatoController : Controller
    {
        // GET: AtribuirRespRelato
        public ActionResult Index()
        {
            return View();
        }
    }
}