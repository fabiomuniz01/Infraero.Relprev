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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Linq;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.Relato.Commands.ClassificarRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.CrossCutting.Helpers;
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
                    FlgStatusRelato = (int)EnumStatusRelato.NaoIniciado,
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
                if (string.IsNullOrEmpty(command.EmailRelator))
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

            await _emailSender.SendEmailAsync(atribuicao.ResponsavelTecnicoSgso.Email, "Novo relato de prevenção",
                message);
        }

        private async Task SendRn0065Email(long idRelato)
        {
            var callbackUrl = Url.Page(
                "http://www.relprev.com.br");

            var relato = ApiClientFactory.Instance.GetRelatoById((int) idRelato);

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

            //var textoAssunto = "Selecione o assunto";
            //if (resultAssunto.Count == 0)
            //{
            //    textoAssunto = "Nenhum assunto cadastrado nessa unidae de infraestrutura";
            //}

            //resultAssunto.Insert(0, new AssuntoDto { CodAssunto = -1, DscAssunto = textoAssunto });


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
                CodUnidadeInfraestrutura = obj.CodUnidadeInfraestrutura,
                NomUnidadeÌnfraestrutura = resultUnidade.NomUnidadeÌnfraestrutura,
                ListLocal = new SelectList(resultLocalUnidade, "CodLocal", "DscLocal"),
                ListSubLocal = new SelectList(new List<SubLocalDto>(), "CodSubLocal", "DscSubLocal"),
                ListAssunto = new SelectList(resultAssunto, "CodAssunto", "DscAssunto"),
                ListSubAssunto = new SelectList(new List<SubAssuntoDto>(), "CodSubAssunto", "DscSubAssunto"),
                //ListResponsavelTecnico = resultAtribuido;
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
                    FlgStatusRelato = (int)EnumStatusRelato.Ocorrenciaclassificada


                };
                var idRelato = await ApiClientFactory.Instance.ClassificarRelato(command);


                var listAtribuicaoSgso = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(Convert.ToInt32(idRelato));

                foreach (var atribuicao in listAtribuicaoSgso)
                {
                    //email atribuicao
                    await SendRn0064Email(atribuicao);
                }

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch (Exception e)
            {
                return View();
            }
        }


        [ClaimsAuthorize("Atribuir", "Consultar")]
        [HttpPost]
        public async Task<IActionResult> Atribuir(IFormCollection collection, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                SetNotifyMessage((int)EnumNotify.Error, message);
            }
            else
            {
                ViewBag.NotifyMessage = 0;
                ViewBag.Notify = "passou";
            }


            var obj = ApiClientFactory.Instance.GetRelatoById(int.Parse(collection["CodRelato"].ToString()));

            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(obj.CodUnidadeInfraestrutura);
            var resultLocal = ApiClientFactory.Instance.GetLocalById(obj.CodLocal);
            var resultSubLocal = ApiClientFactory.Instance.GetSubLocalById(obj.CodSubLocal);
            var resultAssunto = ApiClientFactory.Instance.GetAssuntoById(obj.CodAssunto);
            var resultSubAssunto = ApiClientFactory.Instance.GetSubAssuntoById(obj.CodSubAssunto);
            var resultEmpresa = ApiClientFactory.Instance.GetEmpresaAll();

            var command = new CreateResponsavelTecnicoCommand
            {

                CodRelato = obj.CodRelato,
                AlteradoPor = User.Identity.Name,
                FlgStatusRelato = (int)EnumStatusRelato.AguardandoParecerTecnico,
                CodResponsavelTecnico = int.Parse(collection["ddlResponsavel"].ToString()),
                CodSituacaoAtribuicao = (int)EnumSituacaoAtribuicao.OcorrenciaAtribuida
            };
            await ApiClientFactory.Instance.AtribuirResponsavelTecnico(command);

            var listAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(obj.CodRelato);
            var listResposavel = ApiClientFactory.Instance.GetResponsavelTecnicoAll();
            var list = new List<ResponsavelTecnicoDto>();
            foreach (var ItemAtribuido in listAtribuido)
            {
                foreach (var responsavelAtribuido in listResposavel)
                {
                    if (ItemAtribuido.CodResponsavelTecnicoSgso == responsavelAtribuido.CodResponsavelTecnico)
                        list.Add(responsavelAtribuido);
                }
            }

            var model = new RelatoModel
            {
                Relato = obj,
                ListRelatoArquivo = obj.ListArquivo,
                CodUnidadeInfraestrutura = obj.CodUnidadeInfraestrutura,
                NomUnidadeÌnfraestrutura = resultUnidade.NomUnidadeÌnfraestrutura,
                NomLocal = resultLocal.DscLocal,
                NomSubLocal = resultSubLocal.DscSubLocal,
                NomAssunto = resultAssunto.DscAssunto,
                NomSubAssunto = resultSubAssunto.DscSubAssunto,
                ListEmpresas = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial"),
                ListResponsavelTecnico = list


            };

            SetCrudMessage(1);

            return View(model);

        }

        [ClaimsAuthorize("Atribuir", "Enviar")]
        public async Task<IActionResult> Atribuir(int id, string message = null)
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
            var resultLocal = ApiClientFactory.Instance.GetLocalById(obj.CodLocal);
            var resultSubLocal = ApiClientFactory.Instance.GetSubLocalById(obj.CodSubLocal);
            var resultAssunto = ApiClientFactory.Instance.GetAssuntoById(obj.CodAssunto);
            var resultSubAssunto = ApiClientFactory.Instance.GetSubAssuntoById(obj.CodSubAssunto);
            var resultEmpresa = ApiClientFactory.Instance.GetEmpresaAll();

            var command = new CreateResponsavelTecnicoCommand
            {

                CodRelato = obj.CodRelato,
                AlteradoPor = User.Identity.Name,
                FlgStatusRelato = (int)EnumStatusRelato.AguardandoParecerTecnico,
                CodResponsavelTecnico = id,
                CodSituacaoAtribuicao = (int)EnumSituacaoAtribuicao.OcorrenciaAtribuida
            };

            await ApiClientFactory.Instance.AtribuirResponsavelTecnico(command);

            var listAtribuido = ApiClientFactory.Instance.GetAtribuicaoByIdRelato(obj.CodRelato);
            var listResposavel = ApiClientFactory.Instance.GetResponsavelTecnicoAll();
            var list = new List<ResponsavelTecnicoDto>();
            foreach (var ItemAtribuido in listAtribuido)
            {
                foreach (var responsavelAtribuido in listResposavel)
                {
                    if (ItemAtribuido.CodResponsavelTecnicoSgso == responsavelAtribuido.CodResponsavelTecnico)
                        list.Add(responsavelAtribuido);
                }
            }
            var model = new RelatoModel
            {
                Relato = obj,
                ListRelatoArquivo = obj.ListArquivo,
                CodUnidadeInfraestrutura = obj.CodUnidadeInfraestrutura,
                NomUnidadeÌnfraestrutura = resultUnidade.NomUnidadeÌnfraestrutura,
                NomLocal = resultLocal.DscLocal,
                NomSubLocal = resultSubLocal.DscSubLocal,
                NomAssunto = resultAssunto.DscAssunto,
                NomSubAssunto = resultSubAssunto.DscSubAssunto,
                ListEmpresas = new SelectList(resultEmpresa, "CodEmpresa", "NomRazaoSocial"),
                ListResponsavelTecnico = list
            };

            return View(model);

        }

        public ActionResult RemoverAtribuicao(int idRelato, int idResponsavel, string message = null)
        {

            return View();

        }
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
            //var texto = "Selecione sub local";
            //if (listDdlSubLocal.Count == 0)
            //{
            //    texto = "Nenhum sub local cadastrado nesse local";
            //}

            //listDdlSubLocal.Insert(0, new SubLocalDto { CodSubLocal = 0, DscSubLocal = texto });

            return Json(new SelectList(listDdlSubLocal, "CodSubLocal", "DscSubLocal"));
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
            //var texto = "Selecione o sub assunto";
            //if (listDdlSubAssunto.Count == 0)
            //{
            //    texto = "Nenhum sub assunto cadastrado nesse local";
            //}

            //listDdlSubAssunto.Insert(0, new SubAssuntoDto { CodSubAssunto = 0, DscSubAssunto = texto });

            return Json(new SelectList(listDdlSubAssunto, "CodSubAssunto", "DscSubAssunto"));
        }

        [ClaimsAuthorize("Relatos", "Cancelar")]
        public ActionResult Cancel(int id)
        {
            var obj = ApiClientFactory.Instance.GetRelatoById(id);
            var resultUnidade = ApiClientFactory.Instance.GetUnidadeInfraEstruturaById(obj.CodUnidadeInfraestrutura);

            var model = new RelatoModel
            {
                Relato = obj,
                ListRelatoArquivo = obj.ListArquivo,
                CodUnidadeInfraestrutura = obj.CodUnidadeInfraestrutura,
                NomUnidadeÌnfraestrutura = resultUnidade.NomUnidadeÌnfraestrutura
            };

            return View(model);
        }

        [ClaimsAuthorize("Relatos", "Cancelar")]
        [HttpPost]
        public ActionResult Cancel(IFormCollection collection)
        {
            try
            {

                var command = new CancelRelatoCommand
                {


                    CodRelato = int.Parse(collection["CodRelato"].ToString()),
                    DscMotivoCancelamento = collection["DscMotivoCancelamento"].ToString(),
                    AlteradoPor = User.Identity.Name,
                    FlgStatusRelato = EnumStatusRelato.Cancelado.GetHashCode(),

                };

                ApiClientFactory.Instance.CancelRelato(command);

                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Classificar(IFormCollection collection)
        {
            try
            {
                var command = new ClassificarRelatoCommand
                {
                    CodRelato = int.Parse(collection["CodRelato"].ToString()),
                    AlteradoPor = User.Identity.Name,
                    CodUnidadeInfraestrutura = int.Parse(collection["ddlUnidadeInfraestrutura"].ToString()),
                    DscRelato = collection["DscOcorrenciaRelator"].ToString(),
                    CodLocal = int.Parse(collection["dllLocal"].ToString()),
                    CodSubLocal = int.Parse(collection["dllSubLocal"].ToString()),
                    CodAssunto = int.Parse(collection["dllAssunto"].ToString()),
                    CodSubAssunto = int.Parse(collection["dllSubAssunto"].ToString()),
                    FlgStatusRelato = (int)EnumStatusRelato.AguardandoParecerTecnico,


                };
                ApiClientFactory.Instance.ClassificarRelato(command);


                return RedirectToAction(nameof(Index), new { crud = (int)EnumCrud.Updated });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [HttpPost]
        public string UploadFile()
        {
            string result = string.Empty;

            try
            {

                long size = 0;

                var file = Request.Form.Files;

                var filename = ContentDispositionHeaderValue

                    .Parse(file[0].ContentDisposition)

                    .FileName

                    .Trim();

                string FilePath = _hostingEnvironment.WebRootPath + $@"\{ filename}";

                size += file[0].Length;

                using (FileStream fs = System.IO.File.Create(FilePath))
                {

                    file[0].CopyTo(fs);

                    fs.Flush();
                }



                result = FilePath;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;

        }

        [Route("Infusao/Download/{filename}")]
        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot\\RelatoArquivos", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        [ClaimsAuthorize("Relatos", "Finalizar")]
        public ActionResult Finalize()
        {
            return View();
        }
    }
}