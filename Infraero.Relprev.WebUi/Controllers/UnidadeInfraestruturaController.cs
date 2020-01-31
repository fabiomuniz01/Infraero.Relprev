using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Entities;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class UnidadeInfraEstruturaController : Controller
    {
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;

        public UnidadeInfraEstruturaController(IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient)
        {
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
        }

        //private readonly IUnidadeInfraEstrutura 
        public IActionResult Index()
        {
            var response = _unidadeInfraEstruturaClient.GetGridUnidadeInfraEstrutura();
            return View(response);
        }

        public GridUnidadeInfraEstrutura GetGrid()
        {
            var response = _unidadeInfraEstruturaClient.GetGridUnidadeInfraEstrutura();
            return response;
        }

        // GET: UnidadeInfraEstrutura/Create
        public ActionResult Create()
        {
            //var resultUnidade = _unidadeInfraEstruturaClient.GetDependenciaAll();

            //var model = new UnidadeInfraestruturaModel { ListDependencia = new SelectList(resultUnidade, "dep_codigo", "dep_sigla_nome") };
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
                    Sigla = collection["sigla"].ToString(),
                    NomeUnidade = collection["aeroporto"].ToString(),
                    CodUnidade = collection["codUnidade"].ToString(),
                    Descricao = collection["Descricao"].ToString(),
                    DtIniVigencia = DateTime.ParseExact(collection["DtIniVigencia"].ToString(), "dd/MM/yyyy", null),
                    DtFimVigencia = DateTime.ParseExact(collection["DtFimVigencia"].ToString(), "dd/MM/yyyy", null),
                    CriadoPor = User.Identity.Name
                };
                _unidadeInfraEstruturaClient.CreateUnidadeInfraEstrutura(command);

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
            var obj = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaById(id);
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
                    CodUnidadeInfraestrutura = id,
                    CodUnidade = collection["CodUnidade"].ToString(),
                    Sigla = collection["Sigla"].ToString(),
                    Descricao = collection["Descricao"].ToString(),
                    Endereco = collection["Endereco"].ToString(),
                    DtIniVigencia = DateTime.ParseExact(collection["DtIniVigencia"].ToString(), "dd/MM/yyyy", null),
                    DtFimVigencia = DateTime.ParseExact(collection["DtFimVigencia"].ToString(), "dd/MM/yyyy", null),
                    AlteradorPor = "Amcom Developer"
                };
                _unidadeInfraEstruturaClient.UpdateUnidadeInfraEstrutura(command);

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
                _unidadeInfraEstruturaClient.DeleteUnidadeInfraEstrutura(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public JsonResult GetUnidadeBySigla(string sigla)
        {

            try
            {
                if (string.IsNullOrEmpty(sigla))
                {
                    throw new Exception(
                        "Sigla não informada.");
                }
                var result = _unidadeInfraEstruturaClient.GetDependenciaAll().Where(x => x.dep_sigla.Equals(sigla.ToUpper().Trim())).FirstOrDefault();

                if (result ==null)
                {
                    throw new Exception(
                        "Aeroporto não encontrado.");
                }
                
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }

            
        }
    }
}