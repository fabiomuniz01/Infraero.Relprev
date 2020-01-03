using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class RelatoController : Controller
    {
        private readonly IRelatoClient _relatoClient;
        // GET: Relato
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {
            var response = _relatoClient.GetGridLocal();
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Cancel()
        {
            return View();
        }
        public ActionResult Finalize()
        {
            return View();
        }
    }
}