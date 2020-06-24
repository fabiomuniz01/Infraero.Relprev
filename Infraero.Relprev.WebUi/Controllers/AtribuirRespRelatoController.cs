using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.DeleteAtribiucaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.UpdateAtribuicaoRelato;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
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
        public async Task<ActionResult> Index(int id, int? crud, int? notify, string message = null)
        {
            RelatoModel model = null;

            SetNotifyMessage(notify, message);
            SetCrudMessage(crud);

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

            var resultResponsavel = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id).Where(a => a.ResponsavelTecnico.FlagGestorSgso == false).ToList();



            var result = resultResponsavel.Select(s => new AtribuirRespRelatoModel
            {
                CodEmpresa = s.ResponsavelTecnico.Empresa.CodEmpresa.ToString(),
                NomeEmpresa = s.ResponsavelTecnico.Empresa.NomRazaoSocial,
                CodResponsavel = s.CodResponsavelTecnico.ToString(),
                NomeResponsavel = s.ResponsavelTecnico.NomResponsavelTecnico
            }
            ).ToList();

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
                var listResponsavel = collection["ddlResponsavelTecnico[]"];

                foreach (var resp in listResponsavel)
                {
                    var responsavel = ApiClientFactory.Instance.GetResponsavelTecnicoById(Convert.ToInt32(resp));

                    if (!responsavel.FlagGestorSgso)
                    {
                        var command = new CreateAtribuicaoRelatoCommand
                        {
                            CodRelato = int.Parse(collection["CodRelato"].ToString()),
                            CodResponsavelTecnico = Convert.ToInt32(resp),
                            CriadoPor = User.Identity.Name,
                            FlagAtivo = false,
                            
                        };

                        await ApiClientFactory.Instance.CreateAtribuicaoRelato(command);
                    }
                }

                var commandUpdateRelato = new UpdateRelatoAtribuidoCommand
                {
                    CodRelato = int.Parse(collection["CodRelato"].ToString()),
                    //Rn0039 Ocorrência Atribuída
                    FlgStatusRelato = (int) EnumStatusRelato.Atribuido,
                    DscAtribuicao = "Ocorrência Atribuída, " + DateTime.Now.ToString("dd/MM/yyyy") + ", " +
                                    DateTime.Now.ToString("hh:mm"),
                    AlteradoPor = User.Identity.Name
                };

                await ApiClientFactory.Instance.UpdateRelatoAtribuido(commandUpdateRelato);

                return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Success, id= int.Parse(collection["CodRelato"].ToString()), message="Relato atribuído com sucesso" });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Error, id = int.Parse(collection["CodRelato"].ToString()), message = ex.Message });
            }
        }


        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Cadastrar")]

        public async Task<IActionResult> Delete(string idRelato, string idEmpresa, string idResponsavel)
        {
            try
            {
               
                var resultResponsavel = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(Convert.ToInt32(idRelato))
                    .Where(r => r.ResponsavelTecnico.Empresa.CodEmpresa == Convert.ToInt32(idEmpresa) && r.ResponsavelTecnico.CodResponsavelTecnico == Convert.ToInt32(idResponsavel))
                    .FirstOrDefault();

                if (resultResponsavel != null)
                {
                    var command = new DeleteAtribiucaoRelatoCommand
                    {
                        CodAtribuicao = resultResponsavel.CodAtribuicaoRelato
                    };

                    await ApiClientFactory.Instance.DeleteAtribuicaoRelato(command);
                }


                return RedirectToAction(nameof(Index), new { id = Convert.ToInt32(idRelato), crud = (int)EnumCrud.Deleted });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { id = Convert.ToInt32(idRelato), message = "Erro" });
            }
        }

        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Cadastrar")]
      
        public async Task<IActionResult> Enviar(int id)
        {
            try
            {
                //await ApiClientFactory.Instance.UpdateAtribuicaoEnvioRelato(new UpdateAtribuicaoEnvioRelatoCommand { CodRelato = id });



                var listAtribuicao = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id).Where(s => !s.FlagAtivo).ToList();

                foreach (var item in listAtribuicao)
                {
                    var command = new UpdateAtribuicaoRelatoCommand
                    {
                        CodAtribuicaoRelato = item.CodAtribuicaoRelato,
                        AlteradoPor = User.Identity.Name,
                        FlgStatusRelato = (int)EnumStatusRelato.AguardandoParecerTecnico
                    };

                    await ApiClientFactory.Instance.UpdateAtribuicaoRelato(command);

                }
                return RedirectToAction("Index", "Relato", new { crud = (int)EnumCrud.Updated });
                
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { message = "Erro" });
            }
        }

        //[ClaimsAuthorize("AtribuirResponsavelRelato", "Consultar")]
        public JsonResult GetListResponsavelTecnicoByEmpresa(int idEmpresa, int idRelato)
        {
            var resultResponsavel = ApiClientFactory.Instance.GetResponsavelTecnicoAll().Where(r => r.CodEmpresa == idEmpresa && r.FlagGestorSgso == false).ToList();

            var resultResponsavelAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(idRelato)
                .Where(a => a.ResponsavelTecnico.Empresa.CodEmpresa == idEmpresa)
                .ToList();


            if (resultResponsavel.Count > 0)
            {

                foreach (var atribuido in resultResponsavelAtribuido)
                {
                    for (int i = 0; i < resultResponsavel.Count; i++)
                    {
                        if (resultResponsavel[i].CodResponsavelTecnico == atribuido.ResponsavelTecnico.CodResponsavelTecnico)
                        {
                            resultResponsavel.RemoveAt(i);
                            i--;

                        }
                    }
                }

            }


            return Json(new SelectList(resultResponsavel, "CodResponsavelTecnico", "NomResponsavelTecnico"));
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