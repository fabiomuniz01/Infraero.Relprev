using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class UnidadeInfraestruturaController : Controller
    {
        // GET: UnidadeInfraestrutura
        public ActionResult Index()
        {
            return View();
        }

        // GET: UnidadeInfraestrutura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnidadeInfraestrutura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadeInfraestrutura/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnidadeInfraestrutura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnidadeInfraestrutura/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnidadeInfraestrutura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnidadeInfraestrutura/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}