using System;
using System.Linq;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.DeleteSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
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
    public class SubAssuntoController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public SubAssuntoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        //private readonly ISubAssunto 
        public IActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridSubAssunto();
            return View(response);
        }

        public GridSubAssunto GetGrid()
        {
            var response = ApiClientFactory.Instance.GetGridSubAssunto();
            return response;
        }

        // GET: SubAssunto/Create
        public ActionResult Create()
        {
            var result = ApiClientFactory.Instance.GetAssuntoAll();
            var listAssunto =
                result.Select(
                    s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodAssunto + " - " +
                                s.DscAssunto,
                            Value = s.CodAssunto.ToString()
                        }).ToList();

            var assunto = new SubAssuntoModel
            {
                ListAssunto = listAssunto
            };

            return View(assunto);
        }

        // POST: SubAssunto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateSubAssuntoCommand
                {
                    CodAssunto = int.Parse(collection["CodAssunto"].ToString()),
                    DscSubAssunto = collection["DscSubAssunto"].ToString(),
                    CriadoPor = "Amcom Develper"
                };
                ApiClientFactory.Instance.CreateSubAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: SubAssunto/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetSubAssuntoById(id);
            var result = ApiClientFactory.Instance.GetAssuntoAll();
            var listAssunto =
                result.Select(
                    s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodAssunto + " - " +
                                s.DscAssunto,
                            Value = s.CodAssunto.ToString()
                        }).ToList();

            var assunto = new SubAssuntoModel
            {
                SubAssunto = obj,
                ListAssunto = listAssunto
            };

            return View(assunto);
        }

        // POST: SubAssunto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateSubAssuntoCommand
                {
                    CodSubAssunto = id,
                    DscSubAssunto = collection["DscSubAssunto"].ToString(),
                    AlteradoPor = "Amcom Developer"
                };
                ApiClientFactory.Instance.UpdateSubAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: SubAssunto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteSubAssunto(new DeleteSubAssuntoCommand{Id=id});
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}