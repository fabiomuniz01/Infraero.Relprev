﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class RelatoController : Controller
    {
        private readonly IRelatoClient _relatoClient;
        private readonly ILogger _logger;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;

        public RelatoController(IRelatoClient relatoClient, ILogger<CreateRelatoCommand> logger, IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient, IScopeInformation scope)
        {
            _relatoClient = relatoClient;
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
            _logger = logger;
        }

        // GET: Relato
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateRelatoCommand
                {
                    DatOcorrencia = Convert.ToDateTime(collection["DatOcorrencia"].ToString()),
                    HorOcorrencia = collection["DatOcorrencia"].ToString(),
                    DscEnvolvidosOcorrencia = collection["NomUsuario"].ToString(),
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