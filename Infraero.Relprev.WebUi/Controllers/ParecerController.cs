using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Models;
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
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Linq;
using IdentityServer4.Extensions;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.CrossCutting.Extensions;
using Infraero.Relprev.CrossCutting.Helpers;
using Microsoft.AspNetCore.Hosting;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using EnumSituacaoAtribuicao = Infraero.Relprev.CrossCutting.Enumerators.EnumSituacaoAtribuicao;
using System.Security.Claims;
using System.IO;
using Infraero.Relprev.Application.Parecer.Commands.CreateParecer;
using Infraero.Relprev.Application.Parecer.Commands.AvaluateParecer;
using Infraero.Relprev.Application.Parecer.Commands.CompleteParecer;

using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Application.HistoricoParecer.Queries.GetHistoricoParecer;

namespace Infraero.Relprev.WebUi.Controllers
{
    [Authorize(Policy = ModuloAccess.Relatos)]
    public class ParecerController : BaseController
    {
        private readonly IOptions<SettingsModel> _appSettings;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IEmailSender _emailSender;

        public ParecerController(IOptions<SettingsModel> app, IHostingEnvironment hostingEnvironment, IEmailSender emailSender)
        {
            _appSettings = app;
            _hostingEnvironment = hostingEnvironment;
            _emailSender = emailSender;
            ApplicationSettings.WebApiUrl = _appSettings.Value.WebApiBaseUrl;
        }

        //[ClaimsAuthorize("Parecer", "Cadastrar")]
        public async Task<ActionResult> Create(int id)
        {
           try
            {
                var obj = ApiClientFactory.Instance.GetRelatoById(id);

                var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(obj.CodUnidadeInfraestrutura);
                var resultLocal = ApiClientFactory.Instance.GetLocalAll();
                var resultAssunto = ApiClientFactory.Instance.GetAssuntoAll();
                var resultAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(id);

                var resultLocalUnidade = resultLocal
                    .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura)
                    .Select(s => new LocalDto
                    {
                        CodLocal = s.CodLocal,
                        DscLocal = s.DscLocal
                    }).ToList();

                var model = new ParecerModel
                {
                    Relato = obj,
                    ListLocal = new SelectList(resultLocalUnidade, "CodLocal", "DscLocal"),
                    ListSubLocal = new SelectList(new List<SubLocalDto>(), "CodSubLocal", "DscSubLocal"),
                    ListAssunto = new SelectList(resultAssunto, "CodAssunto", "DscAssunto"),
                    ListSubAssunto = new SelectList(new List<SubAssuntoDto>(), "CodSubAssunto", "DscSubAssunto"),
                };

                var command = new UpdateRelatoAtendimentoCommand
                {
                    CodRelato = id,
                    FlgStatusRelato = (int)EnumStatusRelato.EmAndamento,
                    DscParecerStatus = EnumStatusRelato.EmAndamento.GetDescription() + ", " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    AlteradoPor = User.Identity.Name
                    
                };

                await ApiClientFactory.Instance.UpdateRelatoAtendimento(command);

                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Create), new { notify = (int)EnumNotify.Error, message = ex.Message });
            }

        }

        //[ClaimsAuthorize("Parecer", "Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            try
            {
                string uniqueFileName = null;
                var listParecerArquivo = new List<ParecerArquivoDto>();

                if (collection.Files.Count > 0)
                {
                    var file = collection.Files;

                    foreach (var item in file)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ParecerArquivo");
                        string extension = Path.GetExtension(item.FileName);
                        uniqueFileName = Guid.NewGuid().ToString() + extension;
                        var realName = item.GetFilename();
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        item.CopyTo(new FileStream(filePath, FileMode.Create));

                        listParecerArquivo.Add(new ParecerArquivoDto { NomeArquivo = uniqueFileName, Arquivo = realName, Caminho = "ParecerArquivo" });
                    }
                }

                var command = new CreateParecerCommand
                {
                    CodRelato = int.Parse(collection["CodRelato"].ToString()),
                    DscParecer = collection["DscParecer"].ToString(),
                    ListParecerArquivo = listParecerArquivo,
                    FlgStatusRelato = (int)EnumStatusRelato.OcorrenciaAtendida,
                    FlgStatusParecer = (int)EnumStatusParecer.Atendida,
                    DscParecerStatus = EnumStatusParecer.Atendida.GetDescription() + ", " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    CriadoPor = User.Identity.Name
                };

                var idParecer = await ApiClientFactory.Instance.CreateParecer(command);

               return RedirectToAction(nameof(Create), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Create), new { notify = (int)EnumNotify.Error, message = ex.Message });
            }
        }
   
        public IActionResult Evaluate(int id)
        {
            try
            {
                var objParecer = ApiClientFactory.Instance.GetParecerById(id);

                var obj = ApiClientFactory.Instance.GetRelatoById(objParecer.CodRelato);

                var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(obj.CodUnidadeInfraestrutura);
                var resultLocal = ApiClientFactory.Instance.GetLocalAll();
                var resultAssunto = ApiClientFactory.Instance.GetAssuntoAll();
                var resultAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(objParecer.CodRelato);

                var resultLocalUnidade = resultLocal
                    .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura)
                    .Select(s => new LocalDto
                    {
                        CodLocal = s.CodLocal,
                        DscLocal = s.DscLocal
                    }).ToList();
                  //.StatusParecer = ((EnumStatusRelato)s.FlgStatusRelato).GetDescription();

                var model = new ParecerModel
                {
                    Relato = obj,
                    Parecer = objParecer,
                    ListHistoricoParecer = objParecer.HistoricoParecer,
                    ListParecerArquivo = objParecer.ListArquivo,
                    ListLocal = new SelectList(resultLocalUnidade, "CodLocal", "DscLocal"),
                    ListSubLocal = new SelectList(new List<SubLocalDto>(), "CodSubLocal", "DscSubLocal"),
                    ListAssunto = new SelectList(resultAssunto, "CodAssunto", "DscAssunto"),
                    ListSubAssunto = new SelectList(new List<SubAssuntoDto>(), "CodSubAssunto", "DscSubAssunto"),
                    
                };



                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Create), new { notify = (int)EnumNotify.Error, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Evaluate(IFormCollection collection)
        {
            try
            {
                var flagStatus = Convert.ToInt32(collection["rdoAvaliacao"].ToString());


                var command = new AvaluateParecerCommand
                {
                    CodParecer  = int.Parse(collection["CodParecer"].ToString()),
                    DscMotivoDevolucao = collection["DscMotivoParecer"].ToString(),
                    FlgStatusParecer = flagStatus,
                    DscParecerStatus = ((EnumStatusParecer)flagStatus).GetDescription() + ", " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    AlteradoPor = User.Identity.Name
                };

                var idParecer = await ApiClientFactory.Instance.AvaluateParecer(command);

                return RedirectToAction(nameof(Evaluate), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Evaluate), new { notify = (int)EnumNotify.Error, message = ex.Message });
            }
        }

        public IActionResult Complete(int id)
        {
            try
            {
                var objParecer = ApiClientFactory.Instance.GetParecerById(id);

                var obj = ApiClientFactory.Instance.GetRelatoById(objParecer.CodRelato);

                var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(obj.CodUnidadeInfraestrutura);
                var resultLocal = ApiClientFactory.Instance.GetLocalAll();
                var resultAssunto = ApiClientFactory.Instance.GetAssuntoAll();
                var resultAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(objParecer.CodRelato);

                var resultLocalUnidade = resultLocal
                    .Where(x => x.UnidadeInfraestrutura.CodUnidadeInfraestrutura == obj.CodUnidadeInfraestrutura)
                    .Select(s => new LocalDto
                    {
                        CodLocal = s.CodLocal,
                        DscLocal = s.DscLocal
                    }).ToList();
                //.StatusParecer = ((EnumStatusRelato)s.FlgStatusRelato).GetDescription();

                var model = new ParecerModel
                {
                    Relato = obj,
                    Parecer = objParecer,
                    ListHistoricoParecer = objParecer.HistoricoParecer,
                    ListParecerArquivo = objParecer.ListArquivo,
                    ListLocal = new SelectList(resultLocalUnidade, "CodLocal", "DscLocal"),
                    ListSubLocal = new SelectList(new List<SubLocalDto>(), "CodSubLocal", "DscSubLocal"),
                    ListAssunto = new SelectList(resultAssunto, "CodAssunto", "DscAssunto"),
                    ListSubAssunto = new SelectList(new List<SubAssuntoDto>(), "CodSubAssunto", "DscSubAssunto"),

                };



                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Complete), new { notify = (int)EnumNotify.Error, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Complete(IFormCollection collection)
        {
            try
            {
                string uniqueFileName = null;
                var listParecerArquivo = new List<ParecerArquivoDto>();

                if (collection.Files.Count > 0)
                {
                    var file = collection.Files;

                    foreach (var item in file)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ParecerArquivo");
                        string extension = Path.GetExtension(item.FileName);
                        uniqueFileName = Guid.NewGuid().ToString() + extension;
                        var realName = item.GetFilename();
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        item.CopyTo(new FileStream(filePath, FileMode.Create));

                        listParecerArquivo.Add(new ParecerArquivoDto { NomeArquivo = uniqueFileName, Arquivo = realName, Caminho = "ParecerArquivo" });
                    }
                }


                var command = new CompleteParecerCommand
                {
                    CodParecer = int.Parse(collection["CodParecer"].ToString()),
                    DscComplemtoParecer = collection["DscComplementoParecer"].ToString(),
                    FlgStatusParecer = EnumStatusParecer.ParecerCompletado.GetHashCode(),
                    DscParecerStatus = EnumStatusParecer.ParecerCompletado.GetDescription() + ", " + DateTime.Now.ToString("dd/MM/yyyy") + ", " + DateTime.Now.ToString("hh:mm"),
                    AlteradoPor = User.Identity.Name,
                    ListParecerArquivo = listParecerArquivo
                };

                var idParecer = await ApiClientFactory.Instance.CompleteParecer(command);

                return RedirectToAction(nameof(Complete), new { crud = (int)EnumCrud.Created });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Complete), new { notify = (int)EnumNotify.Error, message = ex.Message });
            }
        }
        public IActionResult Reply()
        {
            return View();
        }
    }
}