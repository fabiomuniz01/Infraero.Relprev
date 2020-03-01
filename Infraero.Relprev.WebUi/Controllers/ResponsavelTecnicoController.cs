using System;
using System.Collections.Generic;
using System.Linq;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.DeleteResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.CrossCutting.Enumerators;
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
    public class ResponsavelTecnicoController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public ResponsavelTecnicoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridResponsavelTecnico();
            return View(response);
        }

        public GridResponsavelTecnico GetGrid()
        {
            var response = ApiClientFactory.Instance.GetGridResponsavelTecnico();
            return response;
        }

        public ActionResult Create()
        {
            var usuario = ApiClientFactory.Instance.GetUsuarioById(User.Identity.Name);

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(usuario.CodUnidadeInfraestrutura);

            var model = new ResponsavelTecnicoModel
            {
                ListUnidadeInfraestrutura = new SelectList(new[] { resultUnidade }, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListEmpresa = new SelectList(new List<EmpresaDto>(), "CodEmpresa", "NomRazaoSocial")
            };
            return View(model);
        }

        public JsonResult GetUnidadeByIdEmpresa(int id)
        {
            var result = ApiClientFactory.Instance.GetEmpresaAll().FirstOrDefault(x => x.CodEmpresa == id)
                .VinculoUnidadeEmpresaList.ToList().Select(s => new UnidadeInfraEstruturaDto { CodUnidadeInfraestrutura = s.CodUnidadeInfraestrutura, NomUnidadeÌnfraestrutura = s.NomUnidadeInfraestrutura }).ToList();

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidadeInfraestrutura = 0, NomUnidadeÌnfraestrutura = "Selecionar Unidade de infraestrutura" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateResponsavelTecnicoCommand
                {

                    EndEmail = collection["EndEmail"].ToString(),
                    NomResponsavelTecnico = collection["NomResponsavelTecnico"].ToString(),
                    NumCpf = collection["cpf"].ToString(),
                    NumTelefone = collection["NumTelefone"].ToString(),
                    NumDocumento = collection["NumDocumento"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodEmpresa = int.Parse(collection["ddlEmpresa"].ToString()),
                    CriadoPor = User.Identity.Name
                };

                ApiClientFactory.Instance.CreateResponsavelTecnico(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            ResponsavelTecnicoModel model = null;

            var obj = ApiClientFactory.Instance.GetResponsavelTecnicoById(id);

            if (obj == null) return View(model);
            var resultEmpresa = ApiClientFactory.Instance.GetEmpresaAll();

            var resultUnidade = resultEmpresa.FirstOrDefault(x => x.CodEmpresa == obj.CodEmpresa)
                ?.VinculoUnidadeEmpresaList.Select(s => new UnidadeInfraEstruturaDto
                {
                    CodUnidadeInfraestrutura = s.CodUnidadeInfraestrutura,
                    NomUnidadeÌnfraestrutura = s.NomUnidadeInfraestrutura
                });


            model = new ResponsavelTecnicoModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura", obj.CodUnidadeInfraestrutura),
                ListEmpresa = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial", obj.CodEmpresa),
                ResponsavelTecnico = obj
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateResponsavelTecnicoCommand
                {
                    Id = id,
                    EndEmail = collection["EndEmail"].ToString(),
                    NomResponsavelTecnico = collection["NomResponsavelTecnico"].ToString(),
                    NumDocumento = collection["NumDocumento"].ToString(),
                    NumCpf = collection["NumCpf"].ToString(),
                    NumTelefone = collection["NumTelefone"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    CodEmpresa = int.Parse(collection["ddlEmpresa"].ToString()),
                    AlteradoPor = User.Identity.Name
                };
                ApiClientFactory.Instance.UpdateResponsavelTecnico(command);

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
                ApiClientFactory.Instance.DeleteResponsavelTecnico(new DeleteResponsavelTecnicoCommand { Id = id });
                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Deleted });
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

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidade = "", DscCodUnidadeDescricao = "Selecionar Unidade de infraestrutura" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"));
        }

        public JsonResult GetResponsavelTecnicoByCpf(string cpf)
        {

            try
            {
                if (string.IsNullOrEmpty(cpf))
                {
                    throw new Exception(
                        "Cpf não informado.");
                }

                var result = ApiClientFactory.Instance.GetResponsavelByCpf(cpf);
                if (result.Result.CodUnidadeInfraestrutura != 0)
                {
                    throw new Exception(
                        "Já existe um responsável técnico cadastrado com esse cpf.");
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