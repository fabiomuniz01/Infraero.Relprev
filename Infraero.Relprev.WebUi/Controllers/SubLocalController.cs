using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
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

        public JsonResult GetListLocalById(int id)
        {
            var resultLocal = _localClient.GetLocalAll()
                .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == id).ToList();

            resultLocal.Insert(0, new LocalDto{ CodLocalStr="", DscLocal = "Selecionar Local de Ocorrência" });

            return Json(new SelectList(resultLocal, "CodLocalStr", "DscLocal"));
        }

        // GET: SubLocal/Create
        public ActionResult Create()
        {
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();
            
            var model = new SubLocalModel {ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao") };

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
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodLocal = int.Parse(collection["ddlLocal"].ToString()),
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

            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();

            var resultLocal = _localClient.GetLocalAll()
                .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura).ToList();

            var model = new SubLocalModel
            {
                SubLocal = obj,
                ListUnidadeInfraestrutura = SetSelectedValue(new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"),obj.CodUnidadeInfraestrutura.ToString()),
                ListLocal = new SelectList(resultLocal, "CodLocal", "DscLocal", obj.CodLocal)
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

        public static SelectList SetSelectedValue(SelectList list, string value)
        {
            if (value != null)
            {
                var selected = list.Where(x => x.Value == value).First();
                selected.Selected = true;
                return list;
            }
            return list;
        }
    }
}