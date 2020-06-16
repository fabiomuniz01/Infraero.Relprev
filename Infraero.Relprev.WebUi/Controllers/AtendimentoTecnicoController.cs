using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
using Infraero.Relprev.CrossCutting.Models;
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
            var resultResponsavelTecnico = ApiClientFactory.Instance.GetResponsavelTecnicoAll();


            ViewBag.UnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura");
            ViewBag.ResponsavelTecnico = new SelectList(resultResponsavelTecnico, "CodResponsavelTecnico", "NomResponsavelTecnico");

            return View(response);
        }
        [HttpPost]
        public ActionResult Index(IFormCollection collection)
        {
            var response = ApiClientFactory.Instance.GetGridRelato();

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();
            var resultResponsavelTecnico = ApiClientFactory.Instance.GetResponsavelTecnicoAll();

            ViewBag.UnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura");
            ViewBag.ResponsavelTecnico = new SelectList(resultResponsavelTecnico, "CodResponsavelTecnico", "NomResponsavelTecnico");


            if (!collection["NumRelato"].ToString().IsNullOrEmpty())
            {
                response.aaData = response.aaData.Where(x => x.NumRelato == collection["NumRelato"].ToString()).ToList();
                ViewBag.NumRelato = collection["NumRelato"].ToString();
            }
                
            
            if(!collection["DtStart"].ToString().IsNullOrEmpty() && !collection["DtEnd"].ToString().IsNullOrEmpty())
            {
                ViewBag.DtStart = collection["DtStart"].ToString();
                ViewBag.DtEnd = collection["DtEnd"].ToString();
                response.aaData = response.aaData.Where(x => x.DatOcorrencia >= Convert.ToDateTime(collection["DtStart"].ToString())
               && x.DatOcorrencia <= Convert.ToDateTime(collection["DtEnd"].ToString())
               ).ToList();
            }
               

            if (!collection["rdoStatus"].ToString().IsNullOrEmpty())
                response.aaData = response.aaData.Where(x => x.FlgStatusRelato == Convert.ToInt32( collection["rdoStatus"].ToString())).ToList();
            
            if (!collection["ddlUnidadeInfraestrutura"].ToString().IsNullOrEmpty())
                response.aaData = response.aaData.Where(x => x.CodUnidadeInfraestrutura == Convert.ToInt32(collection["ddlUnidadeInfraestrutura"].ToString())).ToList();


            return View(response);
        }
    }
}