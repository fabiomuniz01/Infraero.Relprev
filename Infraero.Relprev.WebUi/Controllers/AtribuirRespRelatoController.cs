using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.AtribuirResponsavelRelato)]
    public class AtribuirRespRelatoController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IEmailSender _emailSender;

        public AtribuirRespRelatoController(IOptions<SettingsModel> appSettings, IHostingEnvironment hostingEnvironment, IEmailSender emailSender)
        {
            _appSettings = appSettings;
            _hostingEnvironment = hostingEnvironment;
            _emailSender = emailSender;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Consultar")]
        public async Task<ActionResult> Index(int id, int? notify, string message = null)
        {
            RelatoModel model = null;

            SetNotifyMessage(notify, message);

            if (id == 0) return View(model);

            var obj = ApiClientFactory.Instance.GetRelatoById(id);
            obj.Local = ApiClientFactory.Instance.GetLocalById(obj.CodLocal);
            obj.SubLocal = ApiClientFactory.Instance.GetSubLocalById(obj.CodSubLocal);
            obj.Assunto = ApiClientFactory.Instance.GetAssuntoById(obj.CodAssunto);
            obj.SubAssunto = ApiClientFactory.Instance.GetSubAssuntoById(obj.CodSubAssunto);

            var resultVinculoUnidadeEmpresa = ApiClientFactory.Instance.GetVinculoUnidadeEmpresaAll();

            var resultListEmpresa = resultVinculoUnidadeEmpresa
                .Where(x => x.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura)
                .Select(s => new EmpresaDto
                {
                    CodEmpresa = s.CodEmpresa,
                    NomRazaoSocial = s.NomEmpresa
                }).ToList();

            var resultResponsavel = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id);

            var result = resultResponsavel.Select(s => s.ResponsavelTecnico).ToList();

            model = new RelatoModel
            {
                Relato = obj,
                ListEmpresa = new SelectList(resultListEmpresa, "CodEmpresa", "NomRazaoSocial"),
                ListResponsavelTecnico = result

            };

            return View(model);
        }

        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection collection)
        {
            try
            {
                var listResponsavelTecnico = new List<ResponsavelTecnicoDto>();

                foreach (var item in collection["ListCodResponsavel"].ToString().Split(","))
                {
                    if (item.Length > 0)
                        listResponsavelTecnico.Add(ApiClientFactory.Instance.GetResponsavelTecnicoById(Convert.ToInt32(item)));
                }

                foreach (var ItemResponsavel in listResponsavelTecnico)
                {
                    if (!ItemResponsavel.FlagGestorSgso)
                    {
                        var command = new CreateAtribuicaoRelatoCommand
                        {
                            CodRelato = int.Parse(collection["CodRelato"].ToString()),
                            FlgStatusRelato = (int)EnumStatusRelato.AguardandoParecerTecnico,
                            CodResponsavelTecnico = ItemResponsavel.CodResponsavelTecnico,
                            DscAtribuicao = "Ocorrência Atribuída, em " + DateTime.Now.ToString("dd / MM / yyyy") + "," + DateTime.Now.ToString("hh:mm"),
                            CriadoPor = User.Identity.Name,
                            AlteradoPor = User.Identity.Name
                        };

                        var idRelato = await ApiClientFactory.Instance.CreateAtribuicaoRelato(command);
                    }

                }




                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { message = "Erro" });
            }
        }

        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Consultar")]
        public JsonResult GetListResponsavelTecnicoByEmpresa(int id)
        {
            var result = ApiClientFactory.Instance.GetResponsavelTecnicoAll().Where(r => r.CodEmpresa == id).ToList();

            return Json(new SelectList(result, "CodResponsavelTecnico", "NomResponsavelTecnico"));
        }

        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Consultar")]
        public JsonResult GetListResponsavelTecnicoByRelato(int id)
        {
            var resultResponsavel = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id);

            return Json(resultResponsavel.Select(s => new AtribuirRespRelatoModel
            {
                CodEmpresa = s.ResponsavelTecnico.Empresa.CodEmpresa.ToString(),
                NomeEmpresa = s.ResponsavelTecnico.Empresa.NomRazaoSocial,
                CodResponsavel = s.CodResponsavelTecnico.ToString(),
                NomeResponsavel = s.ResponsavelTecnico.NomResponsavelTecnico
            }
            ).ToList());
        }

    }
}