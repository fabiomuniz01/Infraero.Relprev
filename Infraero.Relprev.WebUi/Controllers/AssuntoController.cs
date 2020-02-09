using System;
using Infraero.Relprev.Application.Assunto.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assunto.Commands.UpdateAssunto;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class AssuntoController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public AssuntoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        public IActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridAssunto();
            return View(response);
        }

        // GET: Assunto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assunto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateAssuntoCommand
                {
                    DscAssunto = collection["DscAssunto"].ToString(),
                    CriadoPor = User.Identity.Name
                };
                
                var result = ApiClientFactory.Instance.CreateAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Assunto/Edit/5
//        public async Task<ActionResult> Edit(int id)
//        {
//            try
//            {
//                var obj = await ApiClientFactory.Instance.GetAssuntoById(id);
//            return View(obj);
//        }
//        catch
//        {
//            return View();
//        }
//}

        // POST: Assunto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateAssuntoCommand
                {
                    CodAssunto = id,
                    DscAssunto = collection["DscAssunto"].ToString(),
                    AlteradoPor = "Amcom Developer"
                };
                var result = ApiClientFactory.Instance.UpdateAssunto(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // POST: Assunto/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        ApiClientFactory.Instance.DeleteAssunto(new DeleteAssuntoCommand {Id = 6});

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception e)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
    }
}