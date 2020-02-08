using System;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class RelatoController : Controller
    {
        private readonly IOptions<SettingsModel> _appSettings;

        public RelatoController(IOptions<SettingsModel> app)
        {
            _appSettings = app;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        public ActionResult Create()
        {
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll(); 

            var model = new RelatoModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao")
            };

            return View(model);
        }

        // GET: Relato
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateRelatoCommand
                {
                    DatOcorrencia = Convert.ToDateTime(collection["DatOcorrencia"].ToString()),
                    HorOcorrencia = collection["HorOcorrencia"].ToString(),
                    DscEnvolvidosOcorrencia = collection["DscEnvolvidosOcorrencia"].ToString(),
                    DscLocalOcorrenciaRelator = collection["DscLocalOcorrenciaRelator"].ToString(),
                    DscOcorrenciaRelator = collection["DscOcorrenciaRelator"].ToString(),
                    DscRelato = collection["DscOcorrenciaRelator"].ToString(),
                    NomRelator = collection["NomRelator"].ToString(),
                    EmailRelator  = collection["EmailRelator"].ToString(),
                    NumTelefoneRelator = collection["NumTelefoneRelator"].ToString(),
                    NomEmpresaRelator = collection["NomEmpresaRelator"].ToString()
                };

                ApiClientFactory.Instance.CreateRelato(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            var response = ApiClientFactory.Instance.GetGridRelato();
            return View(response);
        }
        public ActionResult Edit(int id)
        {
            //var obj = ApiClientFactory.Instance.GetRelatoById(id);
            //var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

            //var model = new RelatoModel
            //{
            //    Relato = obj,
            //    ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao", obj.CodUnidadeInfraestrutura.ToString()),
            //};

            return View();
        }
        public ActionResult Cancel()
        {
            return View();
        }
        public ActionResult Finalize()
        {
            return View();
        }
    }
}