using System;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class SubLocalController : Controller
    {
        private readonly ISubLocalClient _subLocalClient;
        private readonly ILocalClient _localClient;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;

        public SubLocalController(ISubLocalClient subLocalClient, 
            ILocalClient localClient, 
            IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient)
        {
            _subLocalClient = subLocalClient;
            _localClient = localClient;
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
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
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();
            var resultLocal = _localClient.GetLocalAll();
            
            var model = new SubLocalModel
            {
                ListUnidadeInfraestrutura = resultUnidade.Select(s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodUnidadeInfraestrutura + " - " +
                                s.Descricao,
                            Value = s.CodUnidadeInfraestrutura.ToString()
                        }).ToList(),
                ListLocal = resultLocal.Select(s =>
                    new SelectListItem()
                    {
                        Text =
                            s.CodLocal + " - " +
                            s.DscLocal,
                        Value = s.CodLocal.ToString()
                    }).ToList()
            };
            return View(model);
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
                    CodUnidadeInfraestrutura = int.Parse(collection["CodUnidadeInfraestrutura"].ToString()),
                    CodLocal = int.Parse(collection["CodLocal"].ToString()),
                    DscSubLocal = collection["DscSubLocal"].ToString(),
                    CriadoPor = "Amcom Developer"
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
            var resultLocal = _localClient.GetLocalAll();
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();

            var model = new SubLocalModel
            {
                SubLocal = obj,
                ListLocal = resultLocal.Select(s =>
                    new SelectListItem()
                    {
                        Text =
                            s.CodLocal + " - " +
                            s.DscLocal,
                        Value = s.CodLocal.ToString()
                    }).ToList(),
                ListUnidadeInfraestrutura = resultUnidade.Select(s =>
                    new SelectListItem()
                    {
                        Text =
                            s.CodUnidade + " - " +
                            s.Descricao,
                        Value = s.CodUnidadeInfraestrutura.ToString()
                    }).ToList()
            };

            return View(model);
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