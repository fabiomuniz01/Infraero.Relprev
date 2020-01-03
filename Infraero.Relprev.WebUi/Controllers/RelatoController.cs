using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class RelatoController : Controller
    {
        private readonly IRelatoClient _relatoClient;
        private readonly ILogger _logger;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;

        public RelatoController(IRelatoClient relatoClient, 
                                IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient)
        {
            _relatoClient = relatoClient;
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient; 
        }

        public ActionResult Create()
        {
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll(); 

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

                _relatoClient.CreateRelato(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            var response = _relatoClient.GetGridRelato();
            return View();
        }
        public ActionResult Edit()
        {
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