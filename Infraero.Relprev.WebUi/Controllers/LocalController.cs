using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Infraero.Relprev.CrossCutting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class LocalController : Controller
    {
        private readonly ILocalClient _localClient;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;

        public LocalController(ILocalClient localClient, IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient)
        {
            _localClient = localClient;
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
        }

        // GET: Local
        public ActionResult Index()
        {
            var response = _localClient.GetGridLocal();
            return View(response);
        }

        // GET: Local/Create
        public ActionResult Create()
        {
            var result = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();
            var listUnidade =
                result.Select(
                    s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodUnidadeInfraestrutura + " - " +
                                s.Descricao,
                            Value = s.CodUnidadeInfraestrutura.ToString()
                        }).ToList();
            var local = new LocalModel
            {
                ListUnidadeInfraestrutura = listUnidade
            };

            return View(local);
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
                    CodUnidadeInfraestrutura = int.Parse(collection["CodUnidadeInfraestrutura"].ToString()),
                    DscLocal = collection["DscLocal"].ToString(),
                    CriadoPor = "Amcom Develper"
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