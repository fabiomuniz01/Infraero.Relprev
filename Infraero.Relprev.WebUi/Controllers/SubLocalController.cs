using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class SubLocalController : Controller
    {
        private readonly ISubLocalClient _subLocalClient;

        public SubLocalController(ISubLocalClient subLocalClient)
        {
            _subLocalClient = subLocalClient;
        }

        //private readonly ISubLocal 
        public IActionResult Index()
        {
            var response = _subLocalClient.GetGridSubLocal();
            return View(response);
        }

        public GridSubLocal GetGrid()
        {
            var response = _subLocalClient.GetGridSubLocal();
            return response;
        }

        // GET: SubLocal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubLocal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateSubLocalCommand
                {
                    //NomSubLocal = collection["SubLocal"].ToString(),
                    CriadoPor = "",
                    //NumCpf = collection["cnpj"].ToString(),
                    //NumTelefone = collection["telefone"].ToString()
                };
                _subLocalClient.CreateSubLocal(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: SubLocal/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _subLocalClient.GetSubLocalById(id);
            return View(obj);
        }

        // POST: SubLocal/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateSubLocalCommand
                {
                    Id = id,
                    //NomSubLocal = collection["SubLocal"].ToString(),
                    AlteradoPor = "",
                    //NumCpf = collection["cnpj"].ToString(),
                    //NumTelefone = collection["telefone"].ToString()
                };
                _subLocalClient.UpdateSubLocal(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: SubLocal/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _subLocalClient.DeleteSubLocal(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}