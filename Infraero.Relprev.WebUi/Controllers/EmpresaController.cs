using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaClient _empresaClient;

        public EmpresaController(IEmpresaClient empresaClient)
        {
            _empresaClient = empresaClient;
        }

        //private readonly IEmpresa 
        public IActionResult Index()
        {
            var response = _empresaClient.GetGridEmpresa();
            return View(response);
        }

        public GridEmpresa GetGrid()
        {
            var response = _empresaClient.GetGridEmpresa();
            return response;
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
                _empresaClient.CreateEmpresa(command);

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
            var obj = _empresaClient.GetEmpresaById(id);
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
                _empresaClient.UpdateEmpresa(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _empresaClient.DeleteEmpresa(id);
                return RedirectToAction(nameof(Index));
            }
            catch
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