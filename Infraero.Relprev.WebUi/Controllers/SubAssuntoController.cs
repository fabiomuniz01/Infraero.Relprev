using System;
using System.Linq;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.DeleteSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class SubAssuntoController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public SubAssuntoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridSubAssunto();
            return View(response);
        }

        
        public ActionResult Create()
        {
            var result = ApiClientFactory.Instance.GetAssuntoAll();

            var assunto = new SubAssuntoModel
            {
                ListAssunto = new SelectList(result, "CodAssunto", "DscAssunto")
            };

            return View(assunto);
        }

        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateSubAssuntoCommand
                {
                    CodAssunto = int.Parse(collection["ddlAssunto"].ToString()),
                    DscSubAssunto = collection["DscSubAssunto"].ToString(),
                    CriadoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.CreateSubAssunto(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetSubAssuntoById(id);
            var result = ApiClientFactory.Instance.GetAssuntoAll();

            var assunto = new SubAssuntoModel
            {
                SubAssunto = obj,
                ListAssunto = new SelectList(result, "CodAssunto", "DscAssunto", obj.CodAssunto)
            };

            return View(assunto);
        }

        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateSubAssuntoCommand
                {
                    CodSubAssunto = id,
                    CodAssunto = int.Parse(collection["ddlAssunto"].ToString()),
                    DscSubAssunto = collection["DscSubAssunto"].ToString(),
                    AlteradoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateSubAssunto(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteSubAssunto(new DeleteSubAssuntoCommand{Id=id});
                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}