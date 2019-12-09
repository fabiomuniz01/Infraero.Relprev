using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class ImportarContratoController : Controller
    {
        public IActionResult Import()
        {
            return View();
        }
        public IActionResult Configure()
        {
            return View();
        }
    }
}