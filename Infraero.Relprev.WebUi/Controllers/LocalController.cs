using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class LocalController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public LocalController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        // GET: Local
        public ActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridLocal();
            return View(response);
        }

        // GET: Local/Create
        public ActionResult Create()
        {
            var result = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();
            var listUnidade =
                result.Select(
                    s =>
                        new SelectListItem()
                        {
                            Text =
                                s.CodUnidadeInfraestrutura + " - " +
                                s.Descricao,
                            Value = s.CodUnidadeInfraestrutura.ToString()
                        }).ToList();
            var local = new LocalModel
            {
                ListUnidadeInfraestrutura = listUnidade
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
                    CodUnidadeInfraestrutura = int.Parse(collection["CodUnidadeInfraestrutura"].ToString()),
                    DscLocal = collection["DscLocal"].ToString(),
                    CriadoPor = "Amcom Develper"
                };
                ApiClientFactory.Instance.CreateLocal(command);

                return RedirectToAction(nameof(Index));
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
                ListUnidadeInfraestrutura = resultUnidade.Select(s =>
                    new SelectListItem()
                    {
                        Text =
                            s.CodUnidadeInfraestrutura + " - " +
                            s.Descricao,
                        Value = s.CodUnidadeInfraestrutura.ToString()
                    }).ToList()
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
                    CodUnidadeInfraestrutura = int.Parse(collection["CodUnidadeInfraestrutura"].ToString()),
                    DscLocal = collection["DscLocal"].ToString(),
                    AlteradoPor = "Amcom Developer"
                };
                ApiClientFactory.Instance.UpdateLocal(command);

                return RedirectToAction(nameof(Index));
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

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        
    }
}