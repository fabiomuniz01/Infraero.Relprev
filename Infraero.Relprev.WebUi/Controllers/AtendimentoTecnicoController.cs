using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class AtendimentoTecnicoController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public AtendimentoTecnicoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }
        public ActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridRelato();
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new AtendimentoTecnicoModel()
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListResponsavel = new SelectList(new List<ResponsavelTecnicoDto>(), "CodResponsavelTecnico", "NomResponsavelTecnico"),
                ListRelato = response
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Index(IFormCollection collection)
        {
            var response = ApiClientFactory.Instance.GetGridRelato();

            if (!collection["ddlResponsavelTecnico"].ToString().IsNullOrEmpty())
            {
                var CodResponsavel = Convert.ToInt32(collection["ddlResponsavelTecnico"].ToString());
                var responseRelatoResp = ApiClientFactory.Instance.GetAtribuicaoRelatoAll().Where(a=>a.ResponsavelTecnico.CodResponsavelTecnico == CodResponsavel).ToList();
                response.aaData = responseRelatoResp.Select(r =>
                                new RelatoDto
                                {
                                    CodRelato = r.Relato.CodRelato,
                                    NumRelato=r.Relato.NumRelato,
                                    FlgStatusRelato=r.Relato.FlgStatusRelato,
                                    UnidadeInfraestrutura =r.Relato.UnidadeInfraestrutura,
                                    DatOcorrencia = r.Relato.DatOcorrencia,
                                    DscOcorrenciaRelator =r.Relato.DscOcorrenciaRelator,
                                    StatusRelato = r.Relato.StatusRelato
                                    
                                }).ToList();
            }

            if (!collection["NumRelato"].ToString().IsNullOrEmpty())
                response.aaData = response.aaData.Where(x => x.NumRelato == collection["NumRelato"].ToString()).ToList();



            if (!collection["DtOcorrenciaInicio"].ToString().IsNullOrEmpty() && !collection["DtOcorrenciaFim"].ToString().IsNullOrEmpty())
            {
                response.aaData = response.aaData.Where(x => x.DatOcorrencia >= Convert.ToDateTime(collection["DtOcorrenciaInicio"].ToString())
               && x.DatOcorrencia <= Convert.ToDateTime(collection["DtOcorrenciaFim"].ToString())
               ).ToList();
            }
           

            if (!collection["rdoStatus"].ToString().IsNullOrEmpty())
                response.aaData = response.aaData.Where(x => x.FlgStatusRelato == Convert.ToInt32(collection["rdoStatus"].ToString())).ToList();

            
           

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new AtendimentoTecnicoModel()
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListResponsavel = new SelectList(new List<ResponsavelTecnicoDto>(), "CodResponsavelTecnico", "NomResponsavelTecnico"),
                ListRelato = response,
                NumRelato = collection["NumRelato"].ToString(),
                DtOcorrenciaInicio= collection["DtOcorrenciaInicio"].ToString(),
                DtOcorrenciaFim = collection["DtOcorrenciaFim"].ToString()

            };

            return View(model);
        }


        #region Metodos publicos

        //[ClaimsAuthorize("AtendimentoTecnico", "Consultar")]
        public JsonResult GetListResponsavelTecnicoByEmpresa(int id)
        {
            var result = ApiClientFactory.Instance.GetResponsavelTecnicoAll().Where(r => r.CodEmpresa == id).ToList();

            return Json(new SelectList(result, "CodResponsavelTecnico", "NomResponsavelTecnico"));
        }


        //[ClaimsAuthorize("AtendimentoTecnico", "Consultar")]
        public JsonResult GetListEmpresaByUnidae(int id)
        {
            var resultVinculoUnidadeEmpresa = ApiClientFactory.Instance.GetVinculoUnidadeEmpresaAll();

            var resultListEmpresa = resultVinculoUnidadeEmpresa
                .Where(x => x.CodUnidadeInfraestrutura == id)
                .Select(s => new EmpresaDto
                {
                    CodEmpresa = s.CodEmpresa,
                    NomRazaoSocial = s.NomEmpresa
                }).ToList();

            //result.Insert(0, new UnidadeInfraEstruturaDto { CodUnidade = "", DscCodUnidadeDescricao = "Selecionar Unidade de infraestrutura" });

            return Json(new SelectList(resultListEmpresa, "CodEmpresa", "NomRazaoSocial"));
        }

        #endregion
    }
}