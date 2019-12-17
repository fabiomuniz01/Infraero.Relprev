using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assunto.Commands.UpdateAssunto;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class AssuntoController : Controller
    {
        private readonly IAssuntoClient _assuntoClient;

        public AssuntoController(IAssuntoClient assuntoClient)
        {
            _assuntoClient = assuntoClient;
        }

        //private readonly IAssunto 
        public IActionResult Index()
        {
            var response = _assuntoClient.GetGridAssunto();
            return View(response);
        }

        public GridAssunto GetGrid()
        {
            var response = _assuntoClient.GetGridAssunto();
            return response;
        }

        // GET: Assunto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assunto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateAssuntoCommand
                {
                    DscAssunto = collection["DscAssunto"].ToString(),
                    CriadoPor = "Amcom Develper"
                };
                _assuntoClient.CreateAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Assunto/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _assuntoClient.GetAssuntoById(id);
            return View(obj);
        }

        // POST: Assunto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateAssuntoCommand
                {
                    CodAssunto = id,
                    DscAssunto = collection["DscAssunto"].ToString(),
                    AlteradoPor = "Amcom Developer"
                };
                _assuntoClient.UpdateAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Assunto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _assuntoClient.DeleteAssunto(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}