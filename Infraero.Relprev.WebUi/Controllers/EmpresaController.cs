using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public EmpresaController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        //private readonly IEmpresa 
        public async Task<IActionResult> Index()
        {
            var response = ApiClientFactory.Instance.GetGridEmpresa();
            return View(response);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateEmpresaCommand
                {
                    Nome = collection["empresa"].ToString(),
                    CriadoPor = "",
                    Cnpj = collection["cnpj"].ToString(),
                    Telefone = collection["telefone"].ToString()
                };
                ApiClientFactory.Instance.CreateEmpresa(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetEmpresaById(id);
            return View(obj);
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateEmpresaCommand
                {
                    Id = id,
                    NomRazaoSocial = collection["empresa"].ToString(),
                    AlteradoPor = "",
                    NumCnpj = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString()
                };
                ApiClientFactory.Instance.UpdateEmpresa(command);

                return RedirectToAction(nameof(Index));
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
                ApiClientFactory.Instance.DeleteEmpresa(new DeleteEmpresaCommand {Id = id});
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }



        // GET: Empresa/Link/5
        public ActionResult Link(int id)
        {
            return View();
        }

        // POST: Empresa/Link/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public ActionResult Link(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}