using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.Usuario.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuario.Commands.DeleteUsuario;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Cadastros)]
    public class UsuarioController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<WebProfileUser> _userManager;
        private readonly IHostingEnvironment _host;

        public UsuarioController(IOptions<SettingsModel> app, IEmailSender emailSender, UserManager<WebProfileUser> userManager, IHostingEnvironment host)
        {
            _appSettings = app;
            _emailSender = emailSender;
            _userManager = userManager;
            _host = host;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("Usuario", "Consultar")]
        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridUsuario();
            return View(response);
        }

        [ClaimsAuthorize("Usuario", "Incluir")]
        public ActionResult Create()
        {
            var resultEmpresa = ApiClientFactory.Instance.GetEmpresaAll();
            var resultPerfil = ApiClientFactory.Instance.GetPerfilAll();

            var model = new UsuarioModel
            {
            ListUnidadeInfraestrutura = new SelectList(new List<UnidadeInfraEstruturaDto>(), "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListEmpresa = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial"),
                ListPerfil = new SelectList(resultPerfil, "CodPerfil", "NomPerfil")
            };
            return View(model);
        }

        [ClaimsAuthorize("Usuario", "Consultar")]
        public JsonResult GetUnidadeByIdEmpresa(int id)
        {
            var result = ApiClientFactory.Instance.GetEmpresaAll().FirstOrDefault(x => x.CodEmpresa == id)
                .VinculoUnidadeEmpresaList.ToList().Select(s => new UnidadeInfraEstruturaDto { CodUnidadeInfraestrutura = s.CodUnidadeInfraestrutura, NomUnidadeÌnfraestrutura = s.NomUnidadeInfraestrutura }).ToList();

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidadeInfraestrutura = 0, NomUnidadeÌnfraestrutura = "Selecionar Unidade de infraestrutura" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"));
        }

        [ClaimsAuthorize("Usuario", "Incluir")]
        [HttpPost]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateUsuarioCommand
                {

                    UserName = collection["EndEmail"].ToString(),
                    Email = collection["EndEmail"].ToString(),
                    Nome = collection["NomUsuario"].ToString(),
                    Cpf = collection["cpf"].ToString(),
                    Telefone = collection["NumTelefone"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodEmpresa = int.Parse(collection["ddlEmpresa"].ToString()),
                    CodPerfil = collection["ddlPerfil"].ToString(),
                    CriadoPor = User.Identity.Name
                };

                ApiClientFactory.Instance.CreateUsuario(command);

                var user = await _userManager.FindByEmailAsync(command.Email);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Usuário não cadastrado.");
                    return View();
                }
                SendNewUserEmail(user, command.Email);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        private async Task SendNewUserEmail(WebProfileUser user, string email)
        {
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var callbackUrl = Url.ActionLink("ResetPassword",
                "Identity/Account", new { code, email });

            var message =
                System.IO.File.ReadAllText(Path.Combine(_host.WebRootPath, "emailtemplates/ConfirmEmail.html"));
            message = message.Replace("%NAME%", user.Nome);
            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl.Replace("%2FAccount", "/Account")));





            await _emailSender.SendEmailAsync(user.Email, "Primeiro acesso sistema Relprev",
                message);
        }

        [ClaimsAuthorize("Usuario", "Alterar")]
        public ActionResult Edit(string id)
        {
            UsuarioModel model = null;

            var obj = ApiClientFactory.Instance.GetUsuarioById(id);

            if (obj == null) return View(model);
            var resultEmpresa = ApiClientFactory.Instance.GetEmpresaAll();

            var resultUnidade = resultEmpresa.FirstOrDefault(x => x.CodEmpresa == obj.CodEmpresa)
                ?.VinculoUnidadeEmpresaList.Select(s => new UnidadeInfraEstruturaDto
                {
                    CodUnidadeInfraestrutura = s.CodUnidadeInfraestrutura,
                    NomUnidadeÌnfraestrutura = s.NomUnidadeInfraestrutura
                });
            var resultPerfil = ApiClientFactory.Instance.GetPerfilAll();


            model = new UsuarioModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura", obj.CodUnidadeInfraestrutura),
                ListEmpresa = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial", obj.CodEmpresa),
                ListPerfil = new SelectList(resultPerfil, "CodPerfil", "NomPerfil", obj.CodPerfil),
                Usuario = obj
            };

            return View(model);
        }

        [ClaimsAuthorize("Usuario", "Alterar")]
        [HttpPost]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateUsuarioCommand
                {

                    UserName = collection["EndEmail"].ToString(),
                    Email = collection["EndEmail"].ToString(),
                    NomUsuario = collection["NomUsuario"].ToString(),
                    NumCpf = collection["NumCpf"].ToString(),
                    NumTelefone = collection["NumTelefone"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodEmpresa = int.Parse(collection["ddlEmpresa"].ToString()),
                    CodPerfil = collection["ddlPerfil"].ToString(),
                    AlteradoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateUsuario(command);

                //var user = await _userManager.FindByEmailAsync(command.Email);

                //if (user == null)
                //{
                //    ModelState.AddModelError(string.Empty, "Usuário não cadastrado.");
                //    return View();
                //}
                //SendNewUserEmail(user, command.Email);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }

        [ClaimsAuthorize("Usuario", "Excluir")]
        public ActionResult Delete(string id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteUsuario(new DeleteUsuarioCommand { Id = id });
                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [ClaimsAuthorize("Usuario", "Consultar")]
        public JsonResult GetListUnidadeById(int id)
        {
            var result = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll()
                .Where(x => x.CodUnidadeInfraestrutura == id).ToList();

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidade = "", DscCodUnidadeDescricao = "Selecionar Unidade de infraestrutura" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"));
        }

        [ClaimsAuthorize("Usuario", "Alterar")]
        public JsonResult GetUsuarioByCpf(string cpf)
        {

            try
            {
                if (string.IsNullOrEmpty(cpf))
                {
                    throw new Exception(
                        "Cpf não informado.");
                }

                var result = ApiClientFactory.Instance.GetUsuarioByCpf(cpf);
                if (result.Result.CodUsuario != null)
                {
                    throw new Exception(
                        "Já existe um usuário cadastrado com esse cpf.");
                }

                return Json(false);


            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }


        }
    }
}