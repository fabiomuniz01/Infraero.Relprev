using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class RelatoController : Controller
    {
        private readonly IRelatoClient _relatoClient;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;

        public RelatoController(IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient, IRelatoClient relatoClient)
        {
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
            _relatoClient = relatoClient;
        }

        // GET: Relato
        public ActionResult Create()
        {
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();

            var model = new RelatoModel { ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao") };

            return View(model);
        }
        public ActionResult Index()
        {
            var response = _relatoClient.GetGridRelato();
            return View(response);
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