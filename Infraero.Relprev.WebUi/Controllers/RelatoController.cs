using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Commands.CancelRelato;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Filter;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.WebUi.Authorization;
using Infraero.Relprev.WebUi.Factory;
using Infraero.Relprev.WebUi.Models;
using Infraero.Relprev.WebUi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Linq;
using IdentityServer4.Extensions;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.Relato.Commands.ClassificarRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.CrossCutting.Extensions;
using Infraero.Relprev.CrossCutting.Helpers;
using Microsoft.AspNetCore.Hosting;
using EnumSituacaoAtribuicao = Infraero.Relprev.CrossCutting.Enumerators.EnumSituacaoAtribuicao;

//using Infraero.Relprev.Application.Relato.Commands.RemoverResponsavelTecnico;

//using System.Web.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Relatos)]
    public class RelatoController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IEmailSender _emailSender;

        public RelatoController(IOptions<SettingsModel> app, IHostingEnvironment hostingEnvironment, IEmailSender emailSender)
        {
            _appSettings = app;
            _hostingEnvironment = hostingEnvironment;
            _emailSender = emailSender;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        #region Métodos Públicos

        [ClaimsAuthorize("Relatos", "Consultar")]
        public IActionResult Index(int? crud)
        {
            SetCrudMessage(crud);
            var response = ApiClientFactory.Instance.GetGridRelato();
            return View(response);
        }

        [ClaimsAuthorize("Relatos", "Cadastrar")]
        public ActionResult Create(string message = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    SetNotifyMessage((int)EnumNotify.Error, message);
                }
                else
                {
                    ViewBag.NotifyMessage = -1;
                    ViewBag.Notify = "null";
                }

                var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaAll();

                var model = new RelatoModel
                {
                    ListUnidadeInfraestrutura = new SelectList(resultUnidade, "CodUnidadeInfraestrutura", "NomUnidadeÌnfraestrutura")
                };

                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Create), new { message = ex.Message });
            }

        }

        [ClaimsAuthorize("Relatos", "Cadastrar")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        //[ServiceFilter(typeof(ValidateReCaptchaAttribute))]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            try
            {
                string uniqueFileName = null;
                var listRelatoArquivo = new List<RelatoArquivoDto>();

                if (collection.Files.Count > 0)
                {
                    var file = collection.Files;

                    foreach (var item in file)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "RelatoArquivo");
                        string extension = Path.GetExtension(item.FileName);
                        uniqueFileName = Guid.NewGuid().ToString() + extension;
                        var realName = item.GetFilename();
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        item.CopyTo(new FileStream(filePath, FileMode.Create));

                        listRelatoArquivo.Add(new RelatoArquivoDto { NomeArquivo = uniqueFileName, Arquivo = realName, Caminho = "RelatoArquivo" });
                    }
                }

                var command = new CreateRelatoCommand
                {
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    DatOcorrencia = collection["DtOcorrencia"].ToString(),
                    HorOcorrencia = collection["HorOcorrencia"].ToString(),
                    DscEnvolvidosOcorrencia = collection["DscEnvolvidosOcorrencia"].ToString(),
                    DscLocalOcorrenciaRelator = collection["DscLocalOcorrenciaRelator"].ToString(),
                    DscOcorrenciaRelator = collection["DscOcorrenciaRelator"].ToString(),
                    DscRelato = collection["DscOcorrenciaRelator"].ToString(),
                    NomRelator = collection["NomRelator"].ToString(),
                    EmailRelator = collection["EmailRelator"].ToString(),
                    //Rn0079
                    NumTelefoneRelator = Criptografia.Encriptar(collection["NumTelefoneRelator"].ToString()),
                    NomEmpresaRelator = collection["NomEmpresaRelator"].ToString(),
                    ListRelatoArquivo = listRelatoArquivo,
                    //Rn0033
                    FlgStatusRelato = (int)EnumStatusRelato.NaoIniciado,
                    DscOcorrenciaStatus = EnumStatusRelato.NaoIniciado.GetDescription() + ", " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    CriadoPor = User.Identity.Name
                };

                var idRelato = await ApiClientFactory.Instance.CreateRelato(command);

                //Rn0064
                var listAtribuicaoSgso = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(Convert.ToInt32(idRelato));

                foreach (var atribuicao in listAtribuicaoSgso)
                {
                    await SendRn0064Email(atribuicao);
                }

                //Rn0065
                if (!string.IsNullOrEmpty(command.EmailRelator))
                {
                    await SendRn0065Email(idRelato);
                }

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Create), new { message = ex.Message });
            }
        }

        [ClaimsAuthorize("Relatos", "Classificar")]
        public ActionResult Edit(int id, string message = null)
        {

            if (!string.IsNullOrEmpty(message))
            {
                SetNotifyMessage((int)EnumNotify.Error, message);
            }
            else
            {
                ViewBag.NotifyMessage = -1;
                ViewBag.Notify = "null";
            }

            var obj = ApiClientFactory.Instance.GetRelatoById(id);

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(obj.CodUnidadeInfraestrutura);
            var resultLocal = ApiClientFactory.Instance.GetLocalAll();
            var resultAssunto = ApiClientFactory.Instance.GetAssuntoAll();
            var resultAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(obj.CodLocal);

            var resultLocalUnidade = resultLocal
                .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura)
                .Select(s => new LocalDto
                {
                    CodLocal = s.CodLocal,
                    DscLocal = s.DscLocal
                }).ToList();

            var model = new RelatoModel
            {
                Relato = obj,
                ListRelatoArquivo = obj.ListArquivo,
                ListLocal = new SelectList(resultLocalUnidade, "CodLocal", "DscLocal"),
                ListSubLocal = new SelectList(new List<SubLocalDto>(), "CodSubLocal", "DscSubLocal"),
                ListAssunto = new SelectList(resultAssunto, "CodAssunto", "DscAssunto"),
                ListSubAssunto = new SelectList(new List<SubAssuntoDto>(), "CodSubAssunto", "DscSubAssunto"),
            };

            return View(model);
        }

        [ClaimsAuthorize("Relatos", "Classificar")]
        [HttpPost]
        public async Task<IActionResult> Edit(IFormCollection collection)
        {
            try
            {
                var command = new ClassificarRelatoCommand
                {
                    CodRelato = int.Parse(collection["CodRelato"].ToString()),
                    AlteradoPor = User.Identity.Name,
                    CodLocal = int.Parse(collection["ddlLocal"].ToString()),
                    CodSubLocal = int.Parse(collection["ddlSubLocal"].ToString()),
                    CodAssunto = int.Parse(collection["ddlAssunto"].ToString()),
                    CodSubAssunto = int.Parse(collection["ddlSubAssunto"].ToString()),
                    //Rn0034
                    FlgStatusRelato = (int)EnumStatusRelato.Ocorrenciaclassificada,
                    DscClassificada = "Ocorrência classificada, " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    //Rn0073
                    DscOcorrenciaRelator = collection["DscOcorrenciaRelator"].ToString(),
                    FlgDscOcorrencia = Convert.ToBoolean(collection["FlgDscOcorrencia"].ToString())
                };

                var idRelato = await ApiClientFactory.Instance.ClassificarRelato(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [ClaimsAuthorize("Relatos", "Cancelar")]
        public ActionResult Cancel(int id, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                SetNotifyMessage((int)EnumNotify.Error, message);
            }
            else
            {
                ViewBag.NotifyMessage = -1;
                ViewBag.Notify = "null";
            }

            var obj = ApiClientFactory.Instance.GetRelatoById(id);

            var model = new RelatoModel
            {
                Relato = obj,
            };

            return View(model);
        }



        [ClaimsAuthorize("Relatos", "Cancelar")]
        [HttpPost]
        public async Task<ActionResult> Cancel(IFormCollection collection)
        {
            try
            {
                var command = new CancelRelatoCommand
                {
                    CodRelato = int.Parse(collection["CodRelato"].ToString()),
                    //Rn0040
                    DscMotivoCancelamento = collection["DscMotivoCancelamento"].ToString(),
                    //Rn0041
                    FlgStatusRelato = (int)EnumStatusRelato.Cancelado,
                    DscCancelamento = "Ocorrência cancelada, " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    AlteradoPor = User.Identity.Name,
                };

                var relato = ApiClientFactory.Instance.GetRelatoById(command.CodRelato);

                //Rn0092
                int[] arrStatus = { (int)EnumStatusRelato.NaoIniciado, (int)EnumStatusRelato.Ocorrenciaclassificada };

                if (arrStatus.Contains(relato.FlgStatusRelato))
                {
                    await ApiClientFactory.Instance.CancelRelato(command);

                    //Rn0042
                    if (!string.IsNullOrEmpty(relato.EmailRelator))
                    {
                        await SendRn0042Email(relato);
                    }
                }
                else
                {
                    return RedirectToAction(nameof(Index), new { message = "O relato poderá ser cancelado somente antes de ser iniciado (Classificado)." });
                }

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        #endregion

        #region Métodos Privados

        public JsonResult GetSubLocalByLocal(int id)
        {
            var listSublocal = ApiClientFactory.Instance.GetSubLocalAll();

            var listDdlSubLocal = listSublocal
                .Where(x => x.Local.CodLocal == id)
                .Select(s => new SubLocalDto
                {
                    CodSubLocal = s.CodSubLocal,
                    DscSubLocal = s.DscSubLocal
                }).ToList();

            listDdlSubLocal.Insert(0, new SubLocalDto { CodSubLocal = 0, DscSubLocal = "Selecione o sub local" });

            return Json(new SelectList(listDdlSubLocal, "CodSubLocal", "DscSubLocal"));
        }
        public JsonResult GetSubAssuntoByLocal(int id)
        {
            var listSubAssunto = ApiClientFactory.Instance.GetSubAssuntoAll();

            var listDdlSubAssunto = listSubAssunto
                .Where(x => x.CodAssunto == id)
                .Select(s => new SubAssuntoDto
                {
                    CodSubAssunto = s.CodSubAssunto,
                    DscSubAssunto = s.DscSubAssunto
                }).ToList();

            listDdlSubAssunto.Insert(0, new SubAssuntoDto { CodSubAssunto = 0, DscSubAssunto = "Selecione o sub assunto" });

            return Json(new SelectList(listDdlSubAssunto, "CodSubAssunto", "DscSubAssunto"));
        }
        private async Task SendRn0064Email(AtribuicaoRelatoDto atribuicao)
        {
            var callbackUrl = Url.Page(
                "/Relato/Edit/" + atribuicao.CodRelato);

            var message =
                System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "emailtemplates/EmailPadrao.html"));

            message = message.Replace("%NAME%", atribuicao.ResponsavelTecnicoSgso.NomUsuario);

            message = message.Replace("%TEXTO%", $"Um novo relato de prevenção foi  cadastrado em {atribuicao.Relato.DatOcorrencia}, " +
                                                 $"às {atribuicao.Relato.HorOcorrencia}, sob o  nº {atribuicao.Relato.NumRelato}. " +
                                                 $"Solicitamos dar tratamento ao relato");

            message = message.Replace("%TXTBOTAO%", "Classificar relato de prevenção");

            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl));

            if (!atribuicao.ResponsavelTecnicoSgso.Email.IsNullOrEmpty())
            {
                await _emailSender.SendEmailAsync(atribuicao.ResponsavelTecnicoSgso.Email, "Novo relato de prevenção",
                    message);
            }
        }
        private async Task SendRn0065Email(long idRelato)
        {
            var callbackUrl = Url.Page(
                "http://www.relprev.com.br");

            var relato = ApiClientFactory.Instance.GetRelatoById((int)idRelato);

            var message =
                System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "emailtemplates/EmailPadrao.html"));

            message = message.Replace("%NAME%", relato.NomRelator);

            message = message.Replace("%TEXTO%", $"Recebemos seu relato registrado em {relato.DatOcorrencia}, às {relato.HorOcorrencia}. " +
                                                 $"O número do seu relato é {relato.NumRelato}. " +
                                                 $"Por meio dele você poderá consultar o andamento das tratativas clicando no botão abaixo. " +
                                                 $"Em breve, você receberá uma resposta contendo uma análise da situação reportada e / ou das ações corretivas implementadas. " +
                                                 $"Agradecemos a sua colaboração para com o nosso sistema de prevenção.");

            message = message.Replace("%TXTBOTAO%", "Andamento relato de prevenção");

            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl));

            await _emailSender.SendEmailAsync(relato.EmailRelator, "Novo relato de prevenção",
                message);
        }
        private async Task SendRn0042Email(RelatoDto relato)
        {
            var callbackUrl = Url.Page(
                "/Relato/Edit/");

            var message =
                System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "emailtemplates/EmailPadrao.html"));

            message = message.Replace("%NAME%", relato.NomEmpresaRelator);

            message = message.Replace("%TEXTO%", $"O relato de prevenção nº {relato.NumRelato} foi  cancelado.");

            message = message.Replace("%TXTBOTAO%", "Classificar relato de prevenção");

            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl));

                await _emailSender.SendEmailAsync(relato.EmailRelator, "Relato de prevenção cancelado.",
                    message);
        }
        #endregion


        public JsonResult GetResponsavelByEmpresa(int id)
        {
            var listResposavel = ApiClientFactory.Instance.GetResponsavelTecnicoAll();

            listResposavel = listResposavel
                .Where(x => x.Empresa.CodEmpresa == id)
                .Select(s => new ResponsavelTecnicoDto
                {
                    CodResponsavelTecnico = s.CodResponsavelTecnico,
                    NomResponsavelTecnico = s.NomResponsavelTecnico
                }).ToList();
            var texto = "Selecione o responsável técnico";
            if (listResposavel.Count == 0)
            {
                texto = "Nenhum responsável técnico cadastrado nesse empresa";
            }

            listResposavel.Insert(0, new ResponsavelTecnicoDto { CodResponsavelTecnico = 0, NomResponsavelTecnico = texto });

            return Json(new SelectList(listResposavel, "CodResponsavelTecnico", "NomResponsavelTecnico"));
        }


        [HttpGet]
        public JsonResult AtribuirResponsavelTecnico(int id)
        {

            var listSublocal = ApiClientFactory.Instance.GetSubLocalAll();

            var listDdlSubLocal = listSublocal
                .Where(x => x.Local.CodLocal == id)
                .Select(s => new SubLocalDto
                {
                    CodSubLocal = s.CodSubLocal,
                    DscSubLocal = s.DscSubLocal
                }).ToList();


            //return Json(new { data = listaClientes }, JsonRequestBehavior.AllowGet);
            return Json(listDdlSubLocal);

        }

        

        [ClaimsAuthorize("Relatos", "Finalizar")]
        public ActionResult Finalize()
        {
            return View();
        }
    }
}