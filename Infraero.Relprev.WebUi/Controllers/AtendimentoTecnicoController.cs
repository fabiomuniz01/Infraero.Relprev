using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;

using Infraero.Relprev.CoreApiClient;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;

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

        //[ClaimsAuthorize("AtendimentoTecnico", "Consultar")]
        public ActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetRelatoAll();
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new AtendimentoTecnicoModel()
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListResponsavel = new SelectList(new List<ResponsavelTecnicoDto>(), "CodResponsavelTecnico", "NomResponsavelTecnico"),
                ListRelato = response
            };

            return View(model);
        }

        //[ClaimsAuthorize("AtendimentoTecnico", "Consultar")]
        [HttpPost]
        public async Task<ActionResult> Index(IFormCollection collection)
        {
            List<RelatoDto> ObjListRelato = new List<RelatoDto>();
            
            var obj = new AtendimentoRequest {
                
                NumRelato = collection["NumRelato"].ToString(),
                CodResponsavelTecnico = Convert.ToInt32(collection["ddlResponsavelTecnico"].ToString()),
                DtOcorrenciaInicio = collection["DtOcorrenciaInicio"].ToString(),
                DtOcorrenciaFim = collection["DtIniOcorrencia"].ToString(),
            };

            var listRelato = await ApiClientFactory.Instance.GetAtendimentoTecnico(obj);

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new AtendimentoTecnicoModel()
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListResponsavel = new SelectList(new List<ResponsavelTecnicoDto>(), "CodResponsavelTecnico", "NomResponsavelTecnico"),
                ListRelato = listRelato,
                NumRelato = obj.NumRelato,
                DtOcorrenciaInicio = obj.DtOcorrenciaInicio,
                DtOcorrenciaFim = obj.DtOcorrenciaFim
            };

            return View(model);
        }


        #region Metodos publicos

        //[ClaimsAuthorize("AtendimentoTecnico", "Consultar")]
        public JsonResult GetListResponsavelTecnicoByEmpresa(int id)
        {
            var result = ApiClientFactory.Instance.GetResponsavelTecnicoByIdEmpresa(id);

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