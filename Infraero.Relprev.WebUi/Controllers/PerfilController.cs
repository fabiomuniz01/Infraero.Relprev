using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    //[Authorize(Roles = "Gestor comercial")]
    public class PerfilController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public PerfilController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        // GET: Perfil
        public ActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridPerfil();
            return View(response);
        }

        // GET: Perfil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perfil/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreatePerfilCommand
                {
                    NomPerfil = collection["NomPerfil"].ToString()
                };
                ApiClientFactory.Instance.CreatePerfil(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Perfil/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetPerfilById(id);
            var model = new PerfilModel(obj);
            return View(model);
        }

        // POST: Perfil/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                var command = new UpdatePerfilCommand
                {
                    CodPerfil = id,
                    NomPerfil = collection["NomPerfil"].ToString()
                };
                ApiClientFactory.Instance.UpdatePerfil(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Perfil/Delete/5
        public ActionResult Delete(string id)
        {
            try
            {
                ApiClientFactory.Instance.DeletePerfil(new DeletePerfilCommand { CodPerfil = id});

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        
    }
}