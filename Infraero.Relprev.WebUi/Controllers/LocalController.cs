using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Cadastros)]
    public class LocalController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public LocalController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("Local", "Consultar")]
        public ActionResult Index(int? crud, int? notify, string message = null)
        {
            SetNotifyMessage(notify, message);
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridLocal();
            return View(response);
        }

        [ClaimsAuthorize("Local", "Incluir")]
        public ActionResult Create()
        {
            var result = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();
            
            var local = new LocalModel
            {
                ListUnidadeInfraestrutura = new SelectList(result, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
            };

            return View(local);
        }

        [ClaimsAuthorize("Local", "Incluir")]
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateLocalCommand
                {
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    DscLocal = collection["DscLocal"].ToString(),
                    CriadoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.CreateLocal(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [ClaimsAuthorize("Local", "Alterar")]
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetLocalById(id);
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new LocalModel()
            {
                Local = obj,
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura", obj.UnidadeInfraestrutura.CodUnidadeInfraestrutura)
            };

            return View(model);
        }

        [ClaimsAuthorize("Local", "Alterar")]
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateLocalCommand
                {
                    CodLocal = id,
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    DscLocal = collection["DscLocal"].ToString(),
                    AlteradoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateLocal(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }

        [ClaimsAuthorize("Local", "Excluir")]
        public ActionResult Delete(int id)
        {
            try
            {
                var local = ApiClientFactory.Instance.GetSubLocalAll().Any(x=>x.Local.CodLocal.Equals(id));

                if (local)
                {
                    return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Warning, message = "Esse Local de Ocorrência possui um Sub Local de Ocorrência a ele vinculado e por isso não pode ser excluído." });
                }

                ApiClientFactory.Instance.DeleteLocal(new DeleteLocalCommand {Id = id});

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        
    }
}