using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class SubAssuntoController : Controller
    {
        // GET: SubAssunto
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubAssunto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubAssunto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubAssunto/Create
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

        // GET: SubAssunto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubAssunto/Edit/5
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

        // GET: SubAssunto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubAssunto/Delete/5
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