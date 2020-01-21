using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.CrossCutting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class PerfilController : Controller
    {
        private readonly IPerfilClient _perfilClient;

        public PerfilController(IPerfilClient perfilClient)
        {
            _perfilClient = perfilClient;
        }

        // GET: Perfil
        public ActionResult Index()
        {
            var response = _perfilClient.GetGridPerfil();
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
                _perfilClient.CreatePerfil(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Perfil/Edit/5
        public ActionResult Edit(string id)
        {
            var obj = _perfilClient.GetPerfilById(id);
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
                _perfilClient.UpdatePerfil(command);

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
                _perfilClient.DeletePerfil(new DeletePerfilCommand { CodPerfil = id});

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        
    }
}