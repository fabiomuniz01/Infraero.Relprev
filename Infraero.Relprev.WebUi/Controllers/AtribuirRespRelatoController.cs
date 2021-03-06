﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.DeleteAtribiucaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.UpdateAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
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
using EnumSituacaoAtribuicao = Infraero.Relprev.CrossCutting.Enumerators.EnumSituacaoAtribuicao;

namespace Infraero.Relprev.WebUi.Controllers
{
    //[Authorize(Policy = ModuloAccess.AtribuirResponsavelRelato)]
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

        [ClaimsAuthorize("AtribuirResponsavelRelato", "Consultar")]
        public async Task<ActionResult> Index(int id, int? crud, int? notify, string message = null)
        {
            AtribuirRespRelatoModel model = null;

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

            var resultVinculoResponsavelEmpresa = ApiClientFactory.Instance.GetVinculoResponsavelEmpresaAll();


            var resultResponsavel = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id).Where(a => a.ResponsavelTecnico.FlagGestorSgso == false);




            foreach (var responsavel in resultResponsavel)
            {
                responsavel.ResponsavelTecnico.DscEmpresa = responsavel.ResponsavelTecnico.ListVinculoResponsavelEmpresa
                    .Where(v => v.CodResponsavelTecnico == responsavel.CodResponsavelTecnico)
                    .FirstOrDefault().Empresa.NomRazaoSocial;
            }

            if (obj.SubLocal == null)
            {
                obj.SubLocal = new SubLocalDto { CodSubLocal = 0 };
            }
            if (obj.SubAssunto == null)
            {
                obj.SubAssunto = new SubAssuntoDto { CodSubAssunto = 0 };
            }
            model = new AtribuirRespRelatoModel
            {
                Relato = obj,
                ListEmpresa = new SelectList(resultListEmpresa, "CodEmpresa", "NomRazaoSocial"),
                ListResponsavelTecnico = resultResponsavel.ToList()
            };

            return View(model);
        }

        [ClaimsAuthorize("AtribuirResponsavelRelato", "Incluir")]
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
                            CodSituacaoAtribuicao = (int)EnumSituacaoAtribuicao.OcorrenciaAtribuida,
                            CodUsuarioAtribuidor = User.FindFirst(ClaimTypes.NameIdentifier).Value,
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
                    FlgStatusRelato = (int)EnumStatusRelato.Atribuido,
                    DscAtribuicao = "Ocorrência Atribuída, " + DateTime.Now.ToString("dd/MM/yyyy") + ", " +
                                    DateTime.Now.ToString("hh:mm"),
                    AlteradoPor = User.Identity.Name
                };

                await ApiClientFactory.Instance.UpdateRelatoAtribuido(commandUpdateRelato);


                return RedirectToAction(nameof(Index), new { id = int.Parse(collection["CodRelato"].ToString()) });

            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Error, id = int.Parse(collection["CodRelato"].ToString()), message = "Erro" });
            }
        }


        [ClaimsAuthorize("AtribuirResponsavelRelato", "Excluir")]
        public async Task<IActionResult> Delete(string idRelato, string idEmpresa, string idResponsavel)
        {
            try
            {

                var resultResponsavel = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(Convert.ToInt32(idRelato))
                    .Where(r => r.ResponsavelTecnico.CodResponsavelTecnico == Convert.ToInt32(idResponsavel))
                    .FirstOrDefault();

                if (resultResponsavel != null)
                {
                    var command = new DeleteAtribiucaoRelatoCommand
                    {
                        CodAtribuicao = resultResponsavel.CodAtribuicaoRelato
                    };

                    await ApiClientFactory.Instance.DeleteAtribuicaoRelato(command);
                }



                return RedirectToAction(nameof(Index), new { id = Convert.ToInt32(idRelato) });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Error, id = Convert.ToInt32(idRelato), message = "Erro" });
            }
        }

        [ClaimsAuthorize("AtribuirResponsavelRelato", "Enviar")]
        public async Task<IActionResult> Enviar(int id)
        {
            try
            {
                var listAtribuicao = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id);
                if (listAtribuicao.Count() == 0)
                {
                    return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Error, id = id, message = "Nenhum responsável técnico foi indicado." });
                }
                foreach (var item in listAtribuicao)
                {
                    var command = new UpdateAtribuicaoRelatoCommand
                    {
                        CodAtribuicaoRelato = item.CodAtribuicaoRelato,
                        AlteradoPor = User.Identity.Name,
                        FlgStatusRelato = (int)EnumStatusRelato.AguardandoParecerTecnico
                    };

                    await ApiClientFactory.Instance.UpdateAtribuicaoRelato(command);

                    //Rn0038
                    await SendRn0038Email(item);

                }

                //Msg0033
                return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Success, id = id, message = "Relato atribuído com sucesso" });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index), new { notify = (int)EnumNotify.Error, id = id, message = ex.Message });
            }
        }

        [ClaimsAuthorize("AtribuirResponsavelRelato", "Consultar")]
        public JsonResult GetListResponsavelTecnicoByEmpresa(int idEmpresa, int idRelato)
        {
            var resultResponsavel = ApiClientFactory.Instance.GetResponsavelTecnicoByIdEmpresa(idEmpresa).Where(e => e.ListVinculoResponsavelEmpresa[0].Empresa.CodEmpresa == idEmpresa).ToList();
            //List<ResponsavelTecnicoDto> resultResponsavel2 = new List<ResponsavelTecnicoDto>();

            //resultResponsavel2 = resultResponsavel.Where(e => e.ListVinculoResponsavelEmpresa[0].Empresa.CodEmpresa == idEmpresa).ToList();

            var resultResponsavelAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(idRelato);

            if (resultResponsavelAtribuido.Any())
            {
                var intersect = resultResponsavel.Select(s => s.CodResponsavelTecnico).Except(resultResponsavelAtribuido.Select(s => s.CodResponsavelTecnico));
                var result = resultResponsavel.Where(x => intersect.Contains(x.CodResponsavelTecnico));

                return Json(new SelectList(result, "CodResponsavelTecnico", "NomResponsavelTecnico"));
            }

            return Json(new SelectList(resultResponsavel, "CodResponsavelTecnico", "NomResponsavelTecnico"));
        }

        private async Task SendRn0038Email(AtribuicaoRelatoDto atribuicao)
        {
            var callbackUrl = Url.Page(
                "/Relato/Index/" + atribuicao.CodRelato);

            var message = System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "emailtemplates/EmailPadrao.html"));

            message = message.Replace("%NAME%", atribuicao.ResponsavelTecnico.NomResponsavelTecnico);

            message = message.Replace("%TEXTO%",
                $"O gestor de SGSO do(a) 'Unidade de Infraestrutura' designou-o como responsável Técnico para " +
                $"responder o Relato Nº   {atribuicao.Relato.NumRelato}, de {atribuicao.Relato.DatOcorrencia}. " +
                $"Para tanto, Solicitamos que click no botão abaixo e emita o seu parecer técnico " +
                $"em ate XX dias corridos contado a  partir do recebimento desse e-mail.");

            message = message.Replace("%TXTBOTAO%", "Realizar Parecer");

            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl));

            if (!string.IsNullOrEmpty(atribuicao.ResponsavelTecnico.EndEmail))
            {
                await _emailSender.SendEmailAsync(atribuicao.ResponsavelTecnico.EndEmail, "Atribuíção de relato de prevenção", message);
            }
        }
    }
}