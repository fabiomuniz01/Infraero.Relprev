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

        [HttpPost]
        public async Task<ActionResult> Index(IFormCollection collection)
        {
            List<RelatoDto> ObjListRelato = new List<RelatoDto>();
            var response = ApiClientFactory.Instance.GetGridRelato();

            //if (!collection["ddlResponsavelTecnico"].ToString().IsNullOrEmpty())
            //{
            //    var CodResponsavel = Convert.ToInt32(collection["ddlResponsavelTecnico"].ToString());
            //    var responseRelatoResp = ApiClientFactory.Instance.GetAtribuicaoRelatoByIdResponsavel(CodResponsavel);

            //    foreach (var Item in responseRelatoResp)
            //    {
            //        ObjListRelato.Add(ApiClientFactory.Instance.GetRelatoById(Item.CodRelato));

            //    }
            //}

            //if (!collection["NumRelato"].ToString().IsNullOrEmpty())
            //{
            //    ObjListRelato.Add(ApiClientFactory.Instance.GetRelatoByNumRelato(collection["NumRelato"].ToString()));

            //}

            //if (!collection["rdoStatus"].ToString().IsNullOrEmpty())
            //{
            //    ObjListRelato = ApiClientFactory.Instance.GetRelatoByStatus(Convert.ToInt32(collection["rdoStatus"].ToString()));

            //}

            //if (!collection["DtStart"].ToString().IsNullOrEmpty() && !collection["DtEnd"].ToString().IsNullOrEmpty())
            //{

            //    DateTime DataInicio = Convert.ToDateTime(collection["DtStart"].ToString());
            //    DateTime DataFim = Convert.ToDateTime(collection["DtEnd"].ToString());

            //    ObjListRelato = ApiClientFactory.Instance.GetRelatoByDate(DataInicio, DataFim);
            //}

           
            
            var atendimentorequet = new AtendimentoTecnicoDto.AtendimentoTecnicoRequest            {
                
                NumRelato = collection["NumRelato"].ToString(),
                CodResponsavelTecnico = collection["ddlResponsavelTecnico"].ToString()
            };


            var relatos = new AtendimentoTecnicoDto.AtendimentoTecnicoResponse
            {
                ListRelato = await ApiClientFactory.Instance.GetAtendimentoTecnico(atendimentorequet)
            };

            //var relatos = await ApiClientFactory.Instance.GetAtendimentoTecnico(atendimento);
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            var model = new AtendimentoTecnicoModel()
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura"),
                ListResponsavel = new SelectList(new List<ResponsavelTecnicoDto>(), "CodResponsavelTecnico", "NomResponsavelTecnico"),
                ListRelato = relatos.ListRelato,
                NumRelato = collection["NumRelato"].ToString(),
                DtOcorrenciaInicio = collection["DtOcorrenciaInicio"].ToString(),
                DtOcorrenciaFim = collection["DtOcorrenciaFim"].ToString()

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