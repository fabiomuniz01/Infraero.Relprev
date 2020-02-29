using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class LocalController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public LocalController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        // GET: Local
        public ActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridLocal();
            return View(response);
        }

        // GET: Local/Create
        public ActionResult Create()
        {
            var result = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();
            
            var local = new LocalModel
            {
                ListUnidadeInfraestrutura = new SelectList(result, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
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

        // GET: Local/Edit/5
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

        // POST: Local/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: Local/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
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