using System;
using System.Linq;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.DeleteUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Cadastros)]
    public class UnidadeInfraEstruturaController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public UnidadeInfraEstruturaController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("Unidade", "Consultar")]
        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);

            var response = ApiClientFactory.Instance.GetGridUnidadeInfraEstrutura();
            return View(response);
        }

        [ClaimsAuthorize("Unidade", "Incluir")]
        public ActionResult Create()
        {
            return View();
        }

        [ClaimsAuthorize("Unidade", "Incluir")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateUnidadeInfraEstruturaCommand
                {
                    Sigla = collection["sigla"].ToString().ToUpper().Trim(),
                    NomUnidadeÌnfraestrutura = collection["aeroporto"].ToString(),
                    Endereco = collection["endereco"].ToString(),
                    CodUnidade = collection["CodUnidade"].ToString(),
                    Descricao = collection["Descricao"].ToString(),
                    DtIniVigencia = collection["DtIniVigencia"].ToString(),
                    DtFimVigencia = collection["DtFimVigencia"].ToString(),
                    CriadoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.CreateUnidadeInfraEstrutura(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [ClaimsAuthorize("Unidade", "Alterar")]
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(id);
            return View(obj);
        }

        [ClaimsAuthorize("Unidade", "Alterar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateUnidadeInfraEstruturaCommand
                {
                    CodUnidadeInfraestrutura = id,
                    Descricao = collection["Descricao"].ToString(),
                    DtIniVigencia = collection["DtIniVigencia"].ToString(),
                    DtFimVigencia = collection["DtFimVigencia"].ToString(),
                    AlteradorPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateUnidadeInfraEstrutura(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch
            {
                return View();
            }
        }

        [ClaimsAuthorize("Unidade", "Excluir")]
        public ActionResult Delete(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteUnidadeInfraEstrutura(new DeleteUnidadeInfraEstruturaCommand { Id = id });
                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [ClaimsAuthorize("Unidade", "Consultar")]
        public JsonResult GetUnidadeBySigla(string sigla)
        {

            try
            {
                if (string.IsNullOrEmpty(sigla))
                {
                    throw new Exception(
                        "Sigla não informada.");
                }

                var exists = ApiClientFactory.Instance
                    .GetUnidadeInfraEstruturaAll().Any(x => x.Sigla.Equals(sigla.ToUpper().Trim()));
                if (exists)
                {
                    throw new Exception(
                        "Já existe uma unidade de infraestrutura cadastrada com esta sigla.");
                }

                var result = ApiClientFactory.Instance.GetDependenciaAll().FirstOrDefault(x => x.dep_sigla.Equals(sigla.ToUpper().Trim()));

                if (result ==null)
                {
                    throw new Exception(
                        "Aeroporto não encontrado.");
                }
                
                return Json(result);
            }
            catch (Exception ex)
            {
                if (ex.Source == "Newtonsoft.Json")
                {
                    return Json("Erro ao estabelecer conexao com o banco de dados.");
                }
                return Json(ex.Message);

            }

            
        }
    }
}