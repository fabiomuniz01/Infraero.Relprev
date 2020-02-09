using System;
using System.Linq;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.Usuario.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuario.Commands.DeleteUsuario;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
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
    public class UsuarioController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public UsuarioController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        //private readonly IUsuario 
        public IActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridUsuario();
            return View(response);
        }

        public GridUsuario GetGrid()
        {
            var response = ApiClientFactory.Instance.GetGridUsuario();
            return response;
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();
            var resultEmpresa = ApiClientFactory.Instance.GetEmpresaAll();
            var resultPerfil = ApiClientFactory.Instance.GetPerfilAll();

            var model = new UsuarioModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"),
                ListEmpresa = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial"),
                ListPerfil = new SelectList(resultPerfil, "CodPerfil","NomPerfil")
            };
            return View(model);
        }
        public ActionResult CreatePerfil()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateUsuarioCommand
                {

                    DateRegistered = DateTime.UtcNow,
                    UserName = collection["EndEmail"].ToString(),
                    Email = collection["EndEmail"].ToString(),
                    Nome = collection["NomUsuario"].ToString(),
                    Cpf = collection["cpf"].ToString(),
                    Telefone = collection["NumTelefone"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodEmpresa = int.Parse(collection["ddlEmpresa"].ToString()),
                    CodPerfil = collection["ddlPerfil"].ToString()
                };
                ApiClientFactory.Instance.CreateUsuario(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetUsuarioById(id);

            var model = new UsuarioModel
            {
                Usuario = obj
            };
            return View(model);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateUsuarioCommand
                {
                    Id = id,
                    NomUsuario = collection["Usuario"].ToString(),
                    AlteradoPor = "",
                    NumCpf = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString()
                };
                ApiClientFactory.Instance.UpdateUsuario(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteUsuario(new DeleteUsuarioCommand {Id = id});
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public JsonResult GetListUnidadeById(int id)
        {
            var result = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll()
                .Where(x => x.CodUnidadeInfraestrutura == id).ToList();

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidade = "", DscCodUnidadeDescricao = "Selecionar Local de Ocorrência" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"));
        }
    }
}