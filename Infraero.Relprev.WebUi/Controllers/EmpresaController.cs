using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.CreateVinculoUnidadeEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.DeleteVinculoUnidadeEmpresa;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class EmpresaController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;
        private readonly UserManager<WebProfileUser> _userManager;

        public EmpresaController(IOptions<SettingsModel> app, UserManager<WebProfileUser> userManager)
        {
            _appSettings = app;
            _userManager = userManager;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        //private readonly IEmpresa 
        public async Task<IActionResult> Index(int? crud)
        {
            SetCrudMessage(crud);

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
                    CriadoPor = User.Identity.Name,
                    Cnpj = collection["cnpj"].ToString(),
                    Telefone = collection["telefone"].ToString(),
                    CpfCriadoPor = _userManager.FindByEmailAsync(User.Identity.Name).Result.Cpf

                };
                ApiClientFactory.Instance.CreateEmpresa(command);


                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
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
                    AlteradoPor = User.Identity.Name,
                    NumCnpj = collection["cnpj"].ToString(),
                    NumTelefone = collection["telefone"].ToString()
                };
                ApiClientFactory.Instance.UpdateEmpresa(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
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
                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public JsonResult GetEmpresaByCnpj(string cnpj)
        {

            try
            {
                if (string.IsNullOrEmpty(cnpj))
                {
                    throw new Exception(
                        "Cnpj não informado.");
                }

                var result = ApiClientFactory.Instance.GetEmpresaByCnpj(cnpj);
                if (result.Result.CodEmpresa!=0)
                {
                    throw new Exception(
                        "Já existe uma empresa cadastrada com esse cnpj.");
                }

                return Json(false);


            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }


        }



        // GET: Empresa/Link/5
        public ActionResult Link(int id)
        {
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var resultVinculo = ApiClientFactory.Instance.GetGridVinculoUnidadeEmpresa();
            resultVinculo.aaData = resultVinculo.aaData.ToList().Where(x => x.CodEmpresa == id);

            var obj = ApiClientFactory.Instance.GetEmpresaById(id);

            var model = new EmpresaModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                Empresa = obj,
                GridVinculoUnidadeEmpresa = resultVinculo
            };

            return View(model);
        }

        // POST: Empresa/Link/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public ActionResult Link(int id, IFormCollection collection)
        {
            try
            {
                var command = new CreateVinculoUnidadeEmpresaCommand
                {
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    NomUnidadeInfraestrutura = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(int.Parse(collection["ddlUnidadeInfraestrutura"].ToString())).NomUnidadeÌnfraestrutura,
                    CodEmpresa = id,
                    NomEmpresa = collection["empresa"].ToString()
                };
                ApiClientFactory.Instance.CreateVinculoUnidadeEmpresa(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult DeleteLink(int id)
        {
            try
            {
                ApiClientFactory.Instance.DeleteVinculoUnidadeEmpresa(new DeleteVinculoUnidadeEmpresaCommand {Id = id});
                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}