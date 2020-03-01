using System;
using System.Collections.Generic;
using System.Linq;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.DeleteSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Cadastros)]
    public class SubLocalController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public SubLocalController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("SubLocal", "Consultar")]
        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridSubLocal();
            return View(response);
        }

        [ClaimsAuthorize("SubLocal", "Consultar")]
        public JsonResult GetListLocalById(int id)
        {
            var resultLocal = ApiClientFactory.Instance.GetLocalAll()
                .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == id).ToList();

            resultLocal.Insert(0, new LocalDto{ CodLocalStr="", DscLocal = "Selecionar Local de Ocorrência" });

            return Json(new SelectList(resultLocal, "CodLocalStr", "DscLocal"));
        }

        [ClaimsAuthorize("SubLocal", "Incluir")]
        public ActionResult Create()
        {
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new SubLocalModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListLocal = new SelectList(new List<LocalDto>(), "CodLocal", "DscLocal")
            };

            return View(model);
        }

        [ClaimsAuthorize("SubLocal", "Incluir")]
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateSubLocalCommand
                {
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodLocal = int.Parse(collection["ddlLocal"].ToString()),
                    DscSubLocal = collection["DscSubLocal"].ToString(),
                    CriadoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.CreateSubLocal(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [ClaimsAuthorize("SubLocal", "Alterar")]
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetSubLocalById(id);

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var resultLocal = ApiClientFactory.Instance.GetLocalAll()
                .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura).ToList();

            var model = new SubLocalModel
            {
                SubLocal = obj,
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura", obj.CodUnidadeInfraestrutura.ToString()),
                ListLocal = new SelectList(resultLocal, "CodLocal", "DscLocal", obj.CodLocal.ToString())
            };

            return View(model);
        }

        [ClaimsAuthorize("SubLocal", "Alterar")]
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateSubLocalCommand
                {
                    Id = id,
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodLocal = int.Parse(collection["ddlLocal"].ToString()),
                    DscSubLocal = collection["DscSubLocal"].ToString(),
                    AlteradoPor = "Amcom Developer",
                };
                ApiClientFactory.Instance.UpdateSubLocal(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }

        [ClaimsAuthorize("SubLocal", "Excluir")]
        public ActionResult Delete(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteSubLocal(new DeleteSubLocalCommand { Id = id });

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }


    }
}