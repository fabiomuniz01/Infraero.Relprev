using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class UnidadeInfraEstruturaController : Controller
    {
        private readonly IUnidadeInfraEstruturaClient _UnidadeInfraEstruturaClient;

        public UnidadeInfraEstruturaController(IUnidadeInfraEstruturaClient UnidadeInfraEstruturaClient)
        {
            _UnidadeInfraEstruturaClient = UnidadeInfraEstruturaClient;
        }

        //private readonly IUnidadeInfraEstrutura 
        public IActionResult Index()
        {
            var response = _UnidadeInfraEstruturaClient.GetGridUnidadeInfraEstrutura();
            return View(response);
        }

        public GridUnidadeInfraEstrutura GetGrid()
        {
            var response = _UnidadeInfraEstruturaClient.GetGridUnidadeInfraEstrutura();
            return response;
        }

        // GET: UnidadeInfraEstrutura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadeInfraEstrutura/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateUnidadeInfraEstruturaCommand
                {
                    CodUnidade = collection["CodUnidade"].ToString(),
                    Sigla = collection["Sigla"].ToString(),
                    Descricao = collection["Descricao"].ToString(),
                    Endereco = collection["Endereco"].ToString(),
                    DtIniVigencia = Convert.ToDateTime(collection["DtIniVigencia"].ToString()),
                    DtFimVigencia = Convert.ToDateTime(collection["DtFimVigencia"].ToString())
                };
                _UnidadeInfraEstruturaClient.CreateUnidadeInfraEstrutura(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: UnidadeInfraEstrutura/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _UnidadeInfraEstruturaClient.GetUnidadeInfraEstruturaById(id);
            return View(obj);
        }

        // POST: UnidadeInfraEstrutura/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateUnidadeInfraEstruturaCommand
                {
                    CodUnidade = collection["CodUnidade"].ToString(),
                    Sigla = collection["Sigla"].ToString(),
                    Descricao = collection["Descricao"].ToString(),
                    Endereco = collection["Endereco"].ToString(),
                    DtIniVigencia = Convert.ToDateTime(collection["DtIniVigencia"].ToString()),
                    DtFimVigencia = Convert.ToDateTime(collection["DtFimVigencia"].ToString())
                };
                _UnidadeInfraEstruturaClient.UpdateUnidadeInfraEstrutura(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: UnidadeInfraEstrutura/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _UnidadeInfraEstruturaClient.DeleteUnidadeInfraEstrutura(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }



        // GET: UnidadeInfraEstrutura/Link/5
        public ActionResult Link(int id)
        {
            return View();
        }

        // POST: UnidadeInfraEstrutura/Link/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public ActionResult Link(int id, IFormCollection collection)
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
    }
}