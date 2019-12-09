using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class ParecerController : Controller
    {
        public IActionResult Complete()
        {
            return View();
        }
        public IActionResult Evaluate()
        {
            return View();
        }
        public IActionResult Reply()
        {
            return View();
        }
    }
}