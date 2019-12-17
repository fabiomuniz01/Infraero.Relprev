using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class LocalController : Controller
    {
        private readonly ILocalClient _localClient;

        public LocalController(ILocalClient localClient)
        {
            _localClient = localClient;
        }

        // GET: Local
        public ActionResult Index()
        {
            var response = _localClient.GetGridLocal();
            return View(response);
        }

        // GET: Local/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Local/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Local/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateLocalCommand
                {
                    DscLocal = collection["Descricao"].ToString(),
                    CriadoPor = ""
                };
                _localClient.CreateLocal(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Local/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Local/Edit/5
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

        // GET: Local/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Local/Delete/5
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