using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class ResponsavelTecnicoController : Controller
    {
        private readonly IResponsavelTecnicoClient _ResponsavelTecnicoClient;

        public ResponsavelTecnicoController(IResponsavelTecnicoClient ResponsavelTecnicoClient)
        {
            _ResponsavelTecnicoClient = ResponsavelTecnicoClient;
        }

        //private readonly IResponsavelTecnico 
        public IActionResult Index()
        {
            var response = _ResponsavelTecnicoClient.GetGridResponsavelTecnico();
            return View(response);
        }

        public GridResponsavelTecnico GetGrid()
        {
            var response = _ResponsavelTecnicoClient.GetGridResponsavelTecnico();
            return response;
        }

        // GET: ResponsavelTecnico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResponsavelTecnico/Create  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateResponsavelTecnicoCommand
                {
                    NomResponsavelTecnico = collection["ResponsavelTecnico"].ToString(),
                    NumCpf = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString(),
                    NumDocumento = collection["documento"].ToString(),
                    EndEmail = collection["email"].ToString(),
                    CriadoPor = "Amcom Develper",
                    DthRegistro = DateTime.Now

                };
                _ResponsavelTecnicoClient.CreateResponsavelTecnico(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: ResponsavelTecnico/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _ResponsavelTecnicoClient.GetResponsavelTecnicoById(id);
            return View(obj);
        }

        // POST: ResponsavelTecnico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateResponsavelTecnicoCommand
                {
                    Id = id,
                    NomResponsavelTecnico = collection["ResponsavelTecnico"].ToString(),
                    AlteradoPor = "",
                    NumCpf = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString()
                };
                _ResponsavelTecnicoClient.UpdateResponsavelTecnico(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: ResponsavelTecnico/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _ResponsavelTecnicoClient.DeleteResponsavelTecnico(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}