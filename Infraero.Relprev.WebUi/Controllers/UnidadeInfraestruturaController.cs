using System;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.DeleteUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
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
    public class UnidadeInfraEstruturaController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public UnidadeInfraEstruturaController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        public IActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridUnidadeInfraEstrutura();
            return View(response);
        }

        public ActionResult Create()
        {
            return View();
        }

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
                    DtIniVigencia = DateTime.ParseExact(collection["DtIniVigencia"].ToString(), "dd/MM/yyyy", null),
                    DtFimVigencia = DateTime.ParseExact(collection["DtFimVigencia"].ToString(), "dd/MM/yyyy", null),
                    CriadoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.CreateUnidadeInfraEstrutura(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: UnidadeInfraEstrutura/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(id);
            return View(obj);
        }

        // POST: UnidadeInfraEstrutura/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateUnidadeInfraEstruturaCommand
                {
                    CodUnidadeInfraestrutura = id,
                    CodUnidade = collection["CodUnidade"].ToString(),
                    Sigla = collection["Sigla"].ToString().ToUpper().Trim(),
                    Descricao = collection["Descricao"].ToString(),
                    Endereco = collection["Endereco"].ToString(),
                    DtIniVigencia = DateTime.ParseExact(collection["DtIniVigencia"].ToString(), "dd/MM/yyyy", null),
                    DtFimVigencia = DateTime.ParseExact(collection["DtFimVigencia"].ToString(), "dd/MM/yyyy", null),
                    AlteradorPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateUnidadeInfraEstrutura(command);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: UnidadeInfraEstrutura/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteUnidadeInfraEstrutura(new DeleteUnidadeInfraEstruturaCommand{Id=id});
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

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
                return Json(ex.Message);

            }

            
        }
    }
}