using System;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.Usuario.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioClient _UsuarioClient;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;
        private readonly IEmpresaClient _empresaClient;
        private readonly IPerfilClient _perfilClient;


        public UsuarioController(IUsuarioClient UsuarioClient,
            IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient, IEmpresaClient empresaClient, IPerfilClient perfilClient)
        {
            _UsuarioClient = UsuarioClient;
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
            _empresaClient = empresaClient;
            _perfilClient = perfilClient;
        }

        //private readonly IUsuario 
        public IActionResult Index()
        {
            var response = _UsuarioClient.GetGridUsuario();
            return View(response);
        }

        public GridUsuario GetGrid()
        {
            var response = _UsuarioClient.GetGridUsuario();
            return response;
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();
            var resultEmpresa = _empresaClient.GetEmpresaAll();
            var resultPerfil = _perfilClient.GetPerfilAll();

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
                    NomUsuario = collection["NomUsuario"].ToString(),
                    NumCpf = collection["NumCpf"].ToString(),
                    EndEmail = collection["EndEmail"].ToString(),
                    NumTelefone = collection["NumTelefone"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    DthRegistro = DateTime.Now,
                    CriadoPor = "Amcom Develper",
                    DataCriacao = DateTime.Now
                };
                _UsuarioClient.CreateUsuario(command);

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
            var obj = _UsuarioClient.GetUsuarioById(id);
            return View(obj);
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
                _UsuarioClient.UpdateUsuario(command);

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
                _UsuarioClient.DeleteUsuario(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public JsonResult GetListUnidadeById(int id)
        {
            var result = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll()
                .Where(x => x.CodUnidadeInfraestrutura == id).ToList();

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidade = "", DscCodUnidadeDescricao = "Selecionar Local de Ocorrência" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"));
        }
    }
}