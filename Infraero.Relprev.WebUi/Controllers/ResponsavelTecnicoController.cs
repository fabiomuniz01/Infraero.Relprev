using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.DeleteResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;

namespace Infraero.Relprev.WebUi.Controllers
{

    [Authorize(Policy = ModuloAccess.Cadastros)]
    public class ResponsavelTecnicoController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public ResponsavelTecnicoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        [ClaimsAuthorize("ResponsavelTecnico", "Consultar")]
        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridResponsavelTecnico();
            return View(response);
        }

        [ClaimsAuthorize("ResponsavelTecnico", "Incluir")]
        public ActionResult Create()
        {
            var usuario = ApiClientFactory.Instance.GetUsuarioById(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(usuario.CodUnidadeInfraestrutura);

            var model = new ResponsavelTecnicoModel
            {
                ListUnidadeInfraestrutura = new SelectList(new[] { resultUnidade }, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListEmpresa = new SelectList(new List<EmpresaDto>(), "CodEmpresa", "NomRazaoSocial")
            };
            return View(model);
        }

        [ClaimsAuthorize("ResponsavelTecnico", "Consultar")]
        public JsonResult GetEmpresaByUnidade(int id)
        {
            var result4 = ApiClientFactory.Instance.GetVinculoUnidadeEmpresaAll();

            var result5 = result4
                .Where(x => x.CodUnidadeInfraestrutura == id)
                .Select(s => new EmpresaDto { 
                    CodEmpresa = s.CodEmpresa,
                    NomRazaoSocial = s.NomEmpresa 
                }).ToList();

            result5.Insert(0, new EmpresaDto { CodEmpresa = 0, NomRazaoSocial = "Selecionar Empresa" });

            return Json(new SelectList(result5, "CodEmpresa", "NomRazaoSocial"));
        }

        [ClaimsAuthorize("ResponsavelTecnico", "Incluir")]
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var listEmpresa = collection["ddlEmpresa[]"].ToArray();
                var command = new CreateResponsavelTecnicoCommand
                {

                    EndEmail = collection["EndEmail"].ToString(),
                    NomResponsavelTecnico = collection["NomResponsavelTecnico"].ToString(),
                    NumCpf = collection["cpf"].ToString(),
                    NumTelefone = collection["NumTelefone"].ToString(),
                    NumDocumento = collection["NumDocumento"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    arrEmpresa = listEmpresa,
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

        [ClaimsAuthorize("ResponsavelTecnico", "Alterar")]
        public ActionResult Edit(int id)
        {
            ResponsavelTecnicoModel model = null;

            var usuario = ApiClientFactory.Instance.GetUsuarioById(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(usuario.CodUnidadeInfraestrutura);

            var obj = ApiClientFactory.Instance.GetResponsavelTecnicoById(id);

            if (obj == null) return View(model);
            var result4 = ApiClientFactory.Instance.GetVinculoUnidadeEmpresaAll();

            var result5 = result4
                .Where(x => x.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura)
                .Select(s => new EmpresaDto
                {
                    CodEmpresa = s.CodEmpresa,
                    NomRazaoSocial = s.NomEmpresa
                }).ToList();

            model = new ResponsavelTecnicoModel
            {
                ListUnidadeInfraestrutura = new SelectList(new[] { resultUnidade }, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura", obj.CodUnidadeInfraestrutura),
                ListEmpresa = new SelectList(result5, "CodEmpresa", "NomRazaoSocial", obj.ListEmpresa.Select(s=>s.CodEmpresa)),
                ResponsavelTecnico = obj
            };

            return View(model);
        }

        [ClaimsAuthorize("ResponsavelTecnico", "Alterar")]
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

        [ClaimsAuthorize("ResponsavelTecnico", "Excluir")]
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

        [ClaimsAuthorize("ResponsavelTecnico", "Consultar")]
        public JsonResult GetListUnidadeById(int id)
        {
            var result = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll()
                .Where(x => x.CodUnidadeInfraestrutura == id).ToList();

            result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidade = "", DscCodUnidadeDescricao = "Selecionar Unidade de infraestrutura" });

            return Json(new SelectList(result, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"));
        }

        [ClaimsAuthorize("ResponsavelTecnico", "Consultar")]
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