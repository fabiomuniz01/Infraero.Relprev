using System;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.DeleteResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Infraero.Relprev.WebUi.Controllers
{
    public class ResponsavelTecnicoController : Controller
    {
        private readonly IResponsavelTecnicoClient _responsavelTecnicoClient;
        private readonly IUnidadeInfraEstruturaClient _unidadeInfraEstruturaClient;
        private readonly IEmpresaClient _empresaClient;

        public ResponsavelTecnicoController(IResponsavelTecnicoClient responsavelTecnicoClient,
            IUnidadeInfraEstruturaClient unidadeInfraEstruturaClient, IEmpresaClient empresaClient)
        {
            _responsavelTecnicoClient = responsavelTecnicoClient;
            _unidadeInfraEstruturaClient = unidadeInfraEstruturaClient;
            _empresaClient = empresaClient;
        }

        //private readonly IResponsavelTecnico 
        public IActionResult Index()
        {
            var response = _responsavelTecnicoClient.GetGridResponsavelTecnico();
            return View(response);
        }

        public GridResponsavelTecnico GetGrid()
        {
            var response = _responsavelTecnicoClient.GetGridResponsavelTecnico();
            return response;
        }

        // GET: ResponsavelTecnico/Create
        public ActionResult Create()
        {
            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();

            var resultEmpresa = _empresaClient.GetEmpresaAll();

            var model = new ResponsavelTecnicoModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "DscCodUnidadeDescricao"),
                ListEmpresa = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial")
            };

            return View(model);
        }

        // POST: ResponsavelTecnico/Create  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var command = new CreateResponsavelTecnicoCommand
                {
                    NomResponsavelTecnico = collection["ResponsavelTecnico"].ToString(),
                    NumCpf = collection["NumCpf"].ToString(),
                    NumTelefone = collection["NumTelefone"].ToString(),
                    NumDocumento = collection["NumDocumento"].ToString(),
                    EndEmail = collection["EndEmail"].ToString(),
                    CodEmpresaResponsavelTecnico = int.Parse(collection["ddlEmpresa"].ToString()),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),

                    CriadoPor = "Amcom Developer",
                    DthRegistro = DateTime.Now

                };
                _responsavelTecnicoClient.CreateResponsavelTecnico(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: ResponsavelTecnico/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _responsavelTecnicoClient.GetResponsavelTecnicoById(id);

            var resultUnidade = _unidadeInfraEstruturaClient.GetUnidadeInfraEstruturaAll();

            var model = new ResponsavelTecnicoModel
            {
                ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura",
                    "DscCodUnidadeDescricao", obj.CodUnidadeInfraestrutura.ToString()),
                ResponsavelTecnico = obj
            };

            return View(model);
        }

        // POST: ResponsavelTecnico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]  
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var command = new UpdateResponsavelTecnicoCommand
                {
                    Id = id,
                    NumTelefone = collection["NumTelefone"].ToString(),
                    NumDocumento = collection["NumDocumento"].ToString(),
                    EndEmail = collection["EndEmail"].ToString(),
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    AlteradoPor= "Amcom Developer"
                };
                _responsavelTecnicoClient.UpdateResponsavelTecnico(command);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _responsavelTecnicoClient.DeleteResponsavelTecnico(new DeleteResponsavelTecnicoCommand{Id = id});

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}